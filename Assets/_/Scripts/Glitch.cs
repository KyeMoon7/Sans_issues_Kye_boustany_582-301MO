using UnityEngine;

/// <summary>
/// Plays a random audio clip at a specific animation moment.
/// </summary>
public class AnimationAudioSync : MonoBehaviour
{
    [Tooltip("List of audio clips to choose from randomly.")]
    public AudioClip[] audioClips;

    [Tooltip("AudioSource component used for playback.")]
    public AudioSource audioSource;

    void Awake()
    {
        // Ensure AudioSource exists
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    /// <summary>
    /// Called by Animation Event at the desired moment.
    /// </summary>
    public void PlayRandomAudio()
    {
        if (audioClips == null || audioClips.Length == 0)
        {
            Debug.LogWarning("No audio clips assigned.");
            return;
        }

        // Pick a random clip
        AudioClip clip = audioClips[Random.Range(0, audioClips.Length)];

        // Play it
        audioSource.PlayOneShot(clip);
    }
}
