/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// Views
    /// </summary>
    [DataContract]
    public partial class Views :  IEquatable<Views>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Views" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="views">views.</param>
        public Views(ViewLinks links = default(ViewLinks), List<View> views = default(List<View>))
        {
            this.Links = links;
            this._Views = views;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public ViewLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets _Views
        /// </summary>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public List<View> _Views { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Views {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  _Views: ").Append(_Views).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Views);
        }

        /// <summary>
        /// Returns true if Views instances are equal
        /// </summary>
        /// <param name="input">Instance of Views to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Views input)
        {
            if (input == null)
                return false;

            return 
                (
                    
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this._Views == input._Views ||
                    this._Views != null &&
                    this._Views.SequenceEqual(input._Views)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this._Views != null)
                    hashCode = hashCode * 59 + this._Views.GetHashCode();
                return hashCode;
            }
        }

    }

}
