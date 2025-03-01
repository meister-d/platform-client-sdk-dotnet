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
    /// PolicyAttributeSet
    /// </summary>
    [DataContract]
    public partial class PolicyAttributeSet :  IEquatable<PolicyAttributeSet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyAttributeSet" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="PolicyAttributes">A set of the attributes checked by the requested policy..</param>
        /// <param name="PresetAttributes">Map of names and values of preset attributes used in this policy..</param>
        public PolicyAttributeSet(string Name = null, List<PolicyAttribute> PolicyAttributes = null, Dictionary<string, TypedAttribute> PresetAttributes = null)
        {
            this.Name = Name;
            this.PolicyAttributes = PolicyAttributes;
            this.PresetAttributes = PresetAttributes;
            
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
        /// A set of the attributes checked by the requested policy.
        /// </summary>
        /// <value>A set of the attributes checked by the requested policy.</value>
        [DataMember(Name="policyAttributes", EmitDefaultValue=false)]
        public List<PolicyAttribute> PolicyAttributes { get; set; }



        /// <summary>
        /// Map of names and values of preset attributes used in this policy.
        /// </summary>
        /// <value>Map of names and values of preset attributes used in this policy.</value>
        [DataMember(Name="presetAttributes", EmitDefaultValue=false)]
        public Dictionary<string, TypedAttribute> PresetAttributes { get; set; }



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
            sb.Append("class PolicyAttributeSet {\n");

            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PolicyAttributes: ").Append(PolicyAttributes).Append("\n");
            sb.Append("  PresetAttributes: ").Append(PresetAttributes).Append("\n");
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
            return this.Equals(obj as PolicyAttributeSet);
        }

        /// <summary>
        /// Returns true if PolicyAttributeSet instances are equal
        /// </summary>
        /// <param name="other">Instance of PolicyAttributeSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyAttributeSet other)
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
                    this.PolicyAttributes == other.PolicyAttributes ||
                    this.PolicyAttributes != null &&
                    this.PolicyAttributes.SequenceEqual(other.PolicyAttributes)
                ) &&
                (
                    this.PresetAttributes == other.PresetAttributes ||
                    this.PresetAttributes != null &&
                    this.PresetAttributes.SequenceEqual(other.PresetAttributes)
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

                if (this.PolicyAttributes != null)
                    hash = hash * 59 + this.PolicyAttributes.GetHashCode();

                if (this.PresetAttributes != null)
                    hash = hash * 59 + this.PresetAttributes.GetHashCode();

                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();

                return hash;
            }
        }
    }

}
