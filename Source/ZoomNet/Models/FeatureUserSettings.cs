using Newtonsoft.Json;

namespace ZoomNet.Models
{
	/// <summary>
	/// Feature user settings.
	/// </summary>
	public class FeatureUserSettings
	{
		/// <summary>
		/// Gets or sets the user's meeting capacity.
		/// </summary>
		[JsonProperty(PropertyName = "meeting_capacity")]
		public int MeetingCapacity { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the large meeting feature is available.
		/// </summary>
		[JsonProperty(PropertyName = "large_meeting")]
		public bool LargeMeetings { get; set; }

		/// <summary>
		/// Gets or sets the user's large meeting capacity.
		/// </summary>
		[JsonProperty(PropertyName = "large_meeting_capacity")]
		public int LargeMeetingCapacity { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the webinar feature is available.
		/// </summary>
		[JsonProperty(PropertyName = "webinar")]
		public bool Webinar { get; set; }

		/// <summary>
		/// Gets or sets the user's webinar capacity.
		/// </summary>
		[JsonProperty(PropertyName = "webinar_capacity")]
		public int WebinarCapacity { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether meetings can be hosted in China.
		/// </summary>
		[JsonProperty(PropertyName = "cn_meeting")]
		public bool MeetingsInChina { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether meetings can be hosted in India.
		/// </summary>
		[JsonProperty(PropertyName = "in_meeting")]
		public bool MeetingsInIndia { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the Zoom phone feature is available.
		/// </summary>
		[JsonProperty(PropertyName = "zoom_phone")]
		public bool ZoomPhone { get; set; }
	}
}
