/*
 * Service for namespace yadayada
 *
 * This service is located at [https://localhost/service-root/](https://localhost/service-root/)
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Org.OpenAPITools.Client.FileParameter;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ErrorErrorMessage
    /// </summary>
    [DataContract(Name = "error_error_message")]
    public partial class ErrorErrorMessage : IEquatable<ErrorErrorMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorErrorMessage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ErrorErrorMessage()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorErrorMessage" /> class.
        /// </summary>
        /// <param name="lang">lang (required).</param>
        /// <param name="value">value (required).</param>
        public ErrorErrorMessage(string lang = default(string), string value = default(string))
        {
            // to ensure "lang" is required (not null)
            if (lang == null)
            {
                throw new ArgumentNullException("lang is a required property for ErrorErrorMessage and cannot be null");
            }
            this.lang = lang;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ErrorErrorMessage and cannot be null");
            }
            this.value = value;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets lang
        /// </summary>
        [DataMember(Name = "lang", IsRequired = true, EmitDefaultValue = true)]
        public string lang { get; set; }

        /// <summary>
        /// Gets or Sets value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string value { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorErrorMessage {\n");
            sb.Append("  lang: ").Append(lang).Append("\n");
            sb.Append("  value: ").Append(value).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ErrorErrorMessage);
        }

        /// <summary>
        /// Returns true if ErrorErrorMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorErrorMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorErrorMessage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.lang == input.lang ||
                    (this.lang != null &&
                    this.lang.Equals(input.lang))
                ) && 
                (
                    this.value == input.value ||
                    (this.value != null &&
                    this.value.Equals(input.value))
                )
                && (this.AdditionalProperties.Count == input.AdditionalProperties.Count && !this.AdditionalProperties.Except(input.AdditionalProperties).Any());
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
                if (this.lang != null)
                {
                    hashCode = (hashCode * 59) + this.lang.GetHashCode();
                }
                if (this.value != null)
                {
                    hashCode = (hashCode * 59) + this.value.GetHashCode();
                }
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
