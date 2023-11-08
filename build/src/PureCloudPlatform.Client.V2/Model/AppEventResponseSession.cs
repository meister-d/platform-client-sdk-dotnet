using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// AppEventResponseSession
    /// </summary>
    [DataContract]
    public partial class AppEventResponseSession :  IEquatable<AppEventResponseSession>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventResponseSession" /> class.
        /// </summary>
        /// <param name="DurationInSeconds">Indicates how long the customer has been in the app within this session..</param>
        /// <param name="EventCount">The count of all events recorded during this session..</param>
        /// <param name="ScreenviewCount">The count of all screen views recorded during this session..</param>
        /// <param name="Referrer">The referrer of the first event in the app session..</param>
        /// <param name="CreatedDate">UTC timestamp of the session's first event, that is when the session starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
        public AppEventResponseSession(int? DurationInSeconds = null, int? EventCount = null, int? ScreenviewCount = null, Referrer Referrer = null, DateTime? CreatedDate = null)
        {
            this.DurationInSeconds = DurationInSeconds;
            this.EventCount = EventCount;
            this.ScreenviewCount = ScreenviewCount;
            this.Referrer = Referrer;
            this.CreatedDate = CreatedDate;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Indicates how long the customer has been in the app within this session.
        /// </summary>
        /// <value>Indicates how long the customer has been in the app within this session.</value>
        [DataMember(Name="durationInSeconds", EmitDefaultValue=false)]
        public int? DurationInSeconds { get; set; }



        /// <summary>
        /// The count of all events recorded during this session.
        /// </summary>
        /// <value>The count of all events recorded during this session.</value>
        [DataMember(Name="eventCount", EmitDefaultValue=false)]
        public int? EventCount { get; set; }



        /// <summary>
        /// The count of all screen views recorded during this session.
        /// </summary>
        /// <value>The count of all screen views recorded during this session.</value>
        [DataMember(Name="screenviewCount", EmitDefaultValue=false)]
        public int? ScreenviewCount { get; set; }



        /// <summary>
        /// The referrer of the first event in the app session.
        /// </summary>
        /// <value>The referrer of the first event in the app session.</value>
        [DataMember(Name="referrer", EmitDefaultValue=false)]
        public Referrer Referrer { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }



        /// <summary>
        /// UTC timestamp of the session's first event, that is when the session starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>UTC timestamp of the session's first event, that is when the session starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppEventResponseSession {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DurationInSeconds: ").Append(DurationInSeconds).Append("\n");
            sb.Append("  EventCount: ").Append(EventCount).Append("\n");
            sb.Append("  ScreenviewCount: ").Append(ScreenviewCount).Append("\n");
            sb.Append("  Referrer: ").Append(Referrer).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AppEventResponseSession);
        }

        /// <summary>
        /// Returns true if AppEventResponseSession instances are equal
        /// </summary>
        /// <param name="other">Instance of AppEventResponseSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppEventResponseSession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.DurationInSeconds == other.DurationInSeconds ||
                    this.DurationInSeconds != null &&
                    this.DurationInSeconds.Equals(other.DurationInSeconds)
                ) &&
                (
                    this.EventCount == other.EventCount ||
                    this.EventCount != null &&
                    this.EventCount.Equals(other.EventCount)
                ) &&
                (
                    this.ScreenviewCount == other.ScreenviewCount ||
                    this.ScreenviewCount != null &&
                    this.ScreenviewCount.Equals(other.ScreenviewCount)
                ) &&
                (
                    this.Referrer == other.Referrer ||
                    this.Referrer != null &&
                    this.Referrer.Equals(other.Referrer)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) &&
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();

                if (this.DurationInSeconds != null)
                    hash = hash * 59 + this.DurationInSeconds.GetHashCode();

                if (this.EventCount != null)
                    hash = hash * 59 + this.EventCount.GetHashCode();

                if (this.ScreenviewCount != null)
                    hash = hash * 59 + this.ScreenviewCount.GetHashCode();

                if (this.Referrer != null)
                    hash = hash * 59 + this.Referrer.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();

                return hash;
            }
        }
    }

}
