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
    /// SequenceSchedule
    /// </summary>
    [DataContract]
    public partial class SequenceSchedule :  IEquatable<SequenceSchedule>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SequenceSchedule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SequenceSchedule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SequenceSchedule" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
        /// <param name="Intervals">A list of intervals during which to run the associated CampaignSequence. (required).</param>
        /// <param name="Recurrences">Recurring schedules of the campaign.</param>
        /// <param name="TimeZone">The time zone for this SequenceSchedule. Defaults to UTC if empty or not provided. See here for a list of valid time zones https://www.iana.org/time-zones.</param>
        /// <param name="Sequence">The CampaignSequence that this SequenceSchedule is for. (required).</param>
        public SequenceSchedule(string Name = null, int? Version = null, List<ScheduleInterval> Intervals = null, List<Reoccurrence> Recurrences = null, string TimeZone = null, DomainEntityRef Sequence = null)
        {
            this.Name = Name;
            this.Version = Version;
            this.Intervals = Intervals;
            this.Recurrences = Recurrences;
            this.TimeZone = TimeZone;
            this.Sequence = Sequence;
            
        }
        


        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }



        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; private set; }



        /// <summary>
        /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
        /// </summary>
        /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; private set; }



        /// <summary>
        /// Required for updates, must match the version number of the most recent update
        /// </summary>
        /// <value>Required for updates, must match the version number of the most recent update</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }



        /// <summary>
        /// A list of intervals during which to run the associated CampaignSequence.
        /// </summary>
        /// <value>A list of intervals during which to run the associated CampaignSequence.</value>
        [DataMember(Name="intervals", EmitDefaultValue=false)]
        public List<ScheduleInterval> Intervals { get; set; }



        /// <summary>
        /// Recurring schedules of the campaign
        /// </summary>
        /// <value>Recurring schedules of the campaign</value>
        [DataMember(Name="recurrences", EmitDefaultValue=false)]
        public List<Reoccurrence> Recurrences { get; set; }



        /// <summary>
        /// The time zone for this SequenceSchedule. Defaults to UTC if empty or not provided. See here for a list of valid time zones https://www.iana.org/time-zones
        /// </summary>
        /// <value>The time zone for this SequenceSchedule. Defaults to UTC if empty or not provided. See here for a list of valid time zones https://www.iana.org/time-zones</value>
        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public string TimeZone { get; set; }



        /// <summary>
        /// The CampaignSequence that this SequenceSchedule is for.
        /// </summary>
        /// <value>The CampaignSequence that this SequenceSchedule is for.</value>
        [DataMember(Name="sequence", EmitDefaultValue=false)]
        public DomainEntityRef Sequence { get; set; }



        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SequenceSchedule {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Intervals: ").Append(Intervals).Append("\n");
            sb.Append("  Recurrences: ").Append(Recurrences).Append("\n");
            sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as SequenceSchedule);
        }

        /// <summary>
        /// Returns true if SequenceSchedule instances are equal
        /// </summary>
        /// <param name="other">Instance of SequenceSchedule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SequenceSchedule other)
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
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Intervals == other.Intervals ||
                    this.Intervals != null &&
                    this.Intervals.SequenceEqual(other.Intervals)
                ) &&
                (
                    this.Recurrences == other.Recurrences ||
                    this.Recurrences != null &&
                    this.Recurrences.SequenceEqual(other.Recurrences)
                ) &&
                (
                    this.TimeZone == other.TimeZone ||
                    this.TimeZone != null &&
                    this.TimeZone.Equals(other.TimeZone)
                ) &&
                (
                    this.Sequence == other.Sequence ||
                    this.Sequence != null &&
                    this.Sequence.Equals(other.Sequence)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();

                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();

                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();

                if (this.Intervals != null)
                    hash = hash * 59 + this.Intervals.GetHashCode();

                if (this.Recurrences != null)
                    hash = hash * 59 + this.Recurrences.GetHashCode();

                if (this.TimeZone != null)
                    hash = hash * 59 + this.TimeZone.GetHashCode();

                if (this.Sequence != null)
                    hash = hash * 59 + this.Sequence.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
