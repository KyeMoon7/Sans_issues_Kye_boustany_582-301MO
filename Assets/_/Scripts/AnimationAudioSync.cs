using UnityEngine;

public class AnimatorAudioSync : MonoBehaviour
{
    public Animator animator;
    public string stateName;
    public AudioClip[] audioClips;
    public AudioSource audioSource;

    private bool hasPlayed;

    void Update()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);

        // Check if we're in the desired state
        if (stateInfo.IsName(stateName))
        {
            // Trigger at 50% of animation
            if (stateInfo.normalizedTime >= 0.5f && !hasPlayed)
            {
                PlayRandomAudio();
                hasPlayed = true;
            }
        }
        else
        {
            hasPlayed = false; // Reset for next time
        }
    }

    void PlayRandomAudio()
    {
        if (audioClips.Length == 0) return;
        AudioClip clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.PlayOneShot(clip);
    }
}