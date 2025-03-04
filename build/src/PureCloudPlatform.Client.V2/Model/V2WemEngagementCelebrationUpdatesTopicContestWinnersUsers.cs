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
    /// V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers
    /// </summary>
    [DataContract]
    public partial class V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers :  IEquatable<V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Rank">Rank.</param>
        public V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers(Guid? Id = null, int? Rank = null)
        {
            this.Id = Id;
            this.Rank = Rank;
            
        }
        


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }



        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public int? Rank { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
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
            return this.Equals(obj as V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers);
        }

        /// <summary>
        /// Returns true if V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers instances are equal
        /// </summary>
        /// <param name="other">Instance of V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2WemEngagementCelebrationUpdatesTopicContestWinnersUsers other)
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
                    this.Rank == other.Rank ||
                    this.Rank != null &&
                    this.Rank.Equals(other.Rank)
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

                if (this.Rank != null)
                    hash = hash * 59 + this.Rank.GetHashCode();

                return hash;
            }
        }
    }

}
