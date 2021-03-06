/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Elli.Api.Loans.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.Model
{
    /// <summary>
    /// LoanContractSelectedHomeCounselingProvider
    /// </summary>
    [DataContract]
    public partial class LoanContractSelectedHomeCounselingProvider :  IEquatable<LoanContractSelectedHomeCounselingProvider>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets SelectedGUID
        /// </summary>
        [DataMember(Name="selectedGUID", EmitDefaultValue=false)]
        public string SelectedGUID { get; set; }

        /// <summary>
        /// Gets or Sets AgencyName
        /// </summary>
        [DataMember(Name="agencyName", EmitDefaultValue=false)]
        public string AgencyName { get; set; }

        /// <summary>
        /// Gets or Sets AgencyAddress
        /// </summary>
        [DataMember(Name="agencyAddress", EmitDefaultValue=false)]
        public string AgencyAddress { get; set; }

        /// <summary>
        /// Gets or Sets AgencyAddressCity
        /// </summary>
        [DataMember(Name="agencyAddressCity", EmitDefaultValue=false)]
        public string AgencyAddressCity { get; set; }

        /// <summary>
        /// Gets or Sets AgencyAddressState
        /// </summary>
        [DataMember(Name="agencyAddressState", EmitDefaultValue=false)]
        public string AgencyAddressState { get; set; }

        /// <summary>
        /// Gets or Sets AgencyAddressPostalCode
        /// </summary>
        [DataMember(Name="agencyAddressPostalCode", EmitDefaultValue=false)]
        public string AgencyAddressPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets AgencyPhoneDirect
        /// </summary>
        [DataMember(Name="agencyPhoneDirect", EmitDefaultValue=false)]
        public string AgencyPhoneDirect { get; set; }

        /// <summary>
        /// Gets or Sets AgencyPhoneTollFree
        /// </summary>
        [DataMember(Name="agencyPhoneTollFree", EmitDefaultValue=false)]
        public string AgencyPhoneTollFree { get; set; }

        /// <summary>
        /// Gets or Sets AgencyFax
        /// </summary>
        [DataMember(Name="agencyFax", EmitDefaultValue=false)]
        public string AgencyFax { get; set; }

        /// <summary>
        /// Gets or Sets AgencyEmail
        /// </summary>
        [DataMember(Name="agencyEmail", EmitDefaultValue=false)]
        public string AgencyEmail { get; set; }

        /// <summary>
        /// Gets or Sets AgencyWebAddress
        /// </summary>
        [DataMember(Name="agencyWebAddress", EmitDefaultValue=false)]
        public string AgencyWebAddress { get; set; }

        /// <summary>
        /// Gets or Sets LanguagesSupported
        /// </summary>
        [DataMember(Name="languagesSupported", EmitDefaultValue=false)]
        public string LanguagesSupported { get; set; }

        /// <summary>
        /// Gets or Sets CounselingServicesProvided
        /// </summary>
        [DataMember(Name="counselingServicesProvided", EmitDefaultValue=false)]
        public string CounselingServicesProvided { get; set; }

        /// <summary>
        /// Gets or Sets AgencyAffiliationDescription
        /// </summary>
        [DataMember(Name="agencyAffiliationDescription", EmitDefaultValue=false)]
        public string AgencyAffiliationDescription { get; set; }

        /// <summary>
        /// Gets or Sets HomeCounselingRequiredIndicator
        /// </summary>
        [DataMember(Name="homeCounselingRequiredIndicator", EmitDefaultValue=false)]
        public bool? HomeCounselingRequiredIndicator { get; set; }

        /// <summary>
        /// Gets or Sets HomeCounselingCompletionDate
        /// </summary>
        [DataMember(Name="homeCounselingCompletionDate", EmitDefaultValue=false)]
        public DateTime? HomeCounselingCompletionDate { get; set; }

        /// <summary>
        /// Gets or Sets CertificationIssuedIndicator
        /// </summary>
        [DataMember(Name="certificationIssuedIndicator", EmitDefaultValue=false)]
        public bool? CertificationIssuedIndicator { get; set; }

        /// <summary>
        /// Gets or Sets HomeCounselingDisclosureDate
        /// </summary>
        [DataMember(Name="homeCounselingDisclosureDate", EmitDefaultValue=false)]
        public DateTime? HomeCounselingDisclosureDate { get; set; }

        /// <summary>
        /// Gets or Sets DistanceMiles
        /// </summary>
        [DataMember(Name="distanceMiles", EmitDefaultValue=false)]
        public double? DistanceMiles { get; set; }

        /// <summary>
        /// Gets or Sets AffiliatedWithLenderIndicator
        /// </summary>
        [DataMember(Name="affiliatedWithLenderIndicator", EmitDefaultValue=false)]
        public bool? AffiliatedWithLenderIndicator { get; set; }

        /// <summary>
        /// Gets or Sets BrrowerSelectCounselorIndicator
        /// </summary>
        [DataMember(Name="brrowerSelectCounselorIndicator", EmitDefaultValue=false)]
        public bool? BrrowerSelectCounselorIndicator { get; set; }

        /// <summary>
        /// Gets or Sets Explanation
        /// </summary>
        [DataMember(Name="explanation", EmitDefaultValue=false)]
        public string Explanation { get; set; }

        /// <summary>
        /// Gets or Sets HomeCounselingGeneratedDate
        /// </summary>
        [DataMember(Name="homeCounselingGeneratedDate", EmitDefaultValue=false)]
        public DateTime? HomeCounselingGeneratedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractSelectedHomeCounselingProvider {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SelectedGUID: ").Append(SelectedGUID).Append("\n");
            sb.Append("  AgencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  AgencyAddress: ").Append(AgencyAddress).Append("\n");
            sb.Append("  AgencyAddressCity: ").Append(AgencyAddressCity).Append("\n");
            sb.Append("  AgencyAddressState: ").Append(AgencyAddressState).Append("\n");
            sb.Append("  AgencyAddressPostalCode: ").Append(AgencyAddressPostalCode).Append("\n");
            sb.Append("  AgencyPhoneDirect: ").Append(AgencyPhoneDirect).Append("\n");
            sb.Append("  AgencyPhoneTollFree: ").Append(AgencyPhoneTollFree).Append("\n");
            sb.Append("  AgencyFax: ").Append(AgencyFax).Append("\n");
            sb.Append("  AgencyEmail: ").Append(AgencyEmail).Append("\n");
            sb.Append("  AgencyWebAddress: ").Append(AgencyWebAddress).Append("\n");
            sb.Append("  LanguagesSupported: ").Append(LanguagesSupported).Append("\n");
            sb.Append("  CounselingServicesProvided: ").Append(CounselingServicesProvided).Append("\n");
            sb.Append("  AgencyAffiliationDescription: ").Append(AgencyAffiliationDescription).Append("\n");
            sb.Append("  HomeCounselingRequiredIndicator: ").Append(HomeCounselingRequiredIndicator).Append("\n");
            sb.Append("  HomeCounselingCompletionDate: ").Append(HomeCounselingCompletionDate).Append("\n");
            sb.Append("  CertificationIssuedIndicator: ").Append(CertificationIssuedIndicator).Append("\n");
            sb.Append("  HomeCounselingDisclosureDate: ").Append(HomeCounselingDisclosureDate).Append("\n");
            sb.Append("  DistanceMiles: ").Append(DistanceMiles).Append("\n");
            sb.Append("  AffiliatedWithLenderIndicator: ").Append(AffiliatedWithLenderIndicator).Append("\n");
            sb.Append("  BrrowerSelectCounselorIndicator: ").Append(BrrowerSelectCounselorIndicator).Append("\n");
            sb.Append("  Explanation: ").Append(Explanation).Append("\n");
            sb.Append("  HomeCounselingGeneratedDate: ").Append(HomeCounselingGeneratedDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as LoanContractSelectedHomeCounselingProvider);
        }

        /// <summary>
        /// Returns true if LoanContractSelectedHomeCounselingProvider instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractSelectedHomeCounselingProvider to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractSelectedHomeCounselingProvider input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SelectedGUID == input.SelectedGUID ||
                    (this.SelectedGUID != null &&
                    this.SelectedGUID.Equals(input.SelectedGUID))
                ) && 
                (
                    this.AgencyName == input.AgencyName ||
                    (this.AgencyName != null &&
                    this.AgencyName.Equals(input.AgencyName))
                ) && 
                (
                    this.AgencyAddress == input.AgencyAddress ||
                    (this.AgencyAddress != null &&
                    this.AgencyAddress.Equals(input.AgencyAddress))
                ) && 
                (
                    this.AgencyAddressCity == input.AgencyAddressCity ||
                    (this.AgencyAddressCity != null &&
                    this.AgencyAddressCity.Equals(input.AgencyAddressCity))
                ) && 
                (
                    this.AgencyAddressState == input.AgencyAddressState ||
                    (this.AgencyAddressState != null &&
                    this.AgencyAddressState.Equals(input.AgencyAddressState))
                ) && 
                (
                    this.AgencyAddressPostalCode == input.AgencyAddressPostalCode ||
                    (this.AgencyAddressPostalCode != null &&
                    this.AgencyAddressPostalCode.Equals(input.AgencyAddressPostalCode))
                ) && 
                (
                    this.AgencyPhoneDirect == input.AgencyPhoneDirect ||
                    (this.AgencyPhoneDirect != null &&
                    this.AgencyPhoneDirect.Equals(input.AgencyPhoneDirect))
                ) && 
                (
                    this.AgencyPhoneTollFree == input.AgencyPhoneTollFree ||
                    (this.AgencyPhoneTollFree != null &&
                    this.AgencyPhoneTollFree.Equals(input.AgencyPhoneTollFree))
                ) && 
                (
                    this.AgencyFax == input.AgencyFax ||
                    (this.AgencyFax != null &&
                    this.AgencyFax.Equals(input.AgencyFax))
                ) && 
                (
                    this.AgencyEmail == input.AgencyEmail ||
                    (this.AgencyEmail != null &&
                    this.AgencyEmail.Equals(input.AgencyEmail))
                ) && 
                (
                    this.AgencyWebAddress == input.AgencyWebAddress ||
                    (this.AgencyWebAddress != null &&
                    this.AgencyWebAddress.Equals(input.AgencyWebAddress))
                ) && 
                (
                    this.LanguagesSupported == input.LanguagesSupported ||
                    (this.LanguagesSupported != null &&
                    this.LanguagesSupported.Equals(input.LanguagesSupported))
                ) && 
                (
                    this.CounselingServicesProvided == input.CounselingServicesProvided ||
                    (this.CounselingServicesProvided != null &&
                    this.CounselingServicesProvided.Equals(input.CounselingServicesProvided))
                ) && 
                (
                    this.AgencyAffiliationDescription == input.AgencyAffiliationDescription ||
                    (this.AgencyAffiliationDescription != null &&
                    this.AgencyAffiliationDescription.Equals(input.AgencyAffiliationDescription))
                ) && 
                (
                    this.HomeCounselingRequiredIndicator == input.HomeCounselingRequiredIndicator ||
                    (this.HomeCounselingRequiredIndicator != null &&
                    this.HomeCounselingRequiredIndicator.Equals(input.HomeCounselingRequiredIndicator))
                ) && 
                (
                    this.HomeCounselingCompletionDate == input.HomeCounselingCompletionDate ||
                    (this.HomeCounselingCompletionDate != null &&
                    this.HomeCounselingCompletionDate.Equals(input.HomeCounselingCompletionDate))
                ) && 
                (
                    this.CertificationIssuedIndicator == input.CertificationIssuedIndicator ||
                    (this.CertificationIssuedIndicator != null &&
                    this.CertificationIssuedIndicator.Equals(input.CertificationIssuedIndicator))
                ) && 
                (
                    this.HomeCounselingDisclosureDate == input.HomeCounselingDisclosureDate ||
                    (this.HomeCounselingDisclosureDate != null &&
                    this.HomeCounselingDisclosureDate.Equals(input.HomeCounselingDisclosureDate))
                ) && 
                (
                    this.DistanceMiles == input.DistanceMiles ||
                    (this.DistanceMiles != null &&
                    this.DistanceMiles.Equals(input.DistanceMiles))
                ) && 
                (
                    this.AffiliatedWithLenderIndicator == input.AffiliatedWithLenderIndicator ||
                    (this.AffiliatedWithLenderIndicator != null &&
                    this.AffiliatedWithLenderIndicator.Equals(input.AffiliatedWithLenderIndicator))
                ) && 
                (
                    this.BrrowerSelectCounselorIndicator == input.BrrowerSelectCounselorIndicator ||
                    (this.BrrowerSelectCounselorIndicator != null &&
                    this.BrrowerSelectCounselorIndicator.Equals(input.BrrowerSelectCounselorIndicator))
                ) && 
                (
                    this.Explanation == input.Explanation ||
                    (this.Explanation != null &&
                    this.Explanation.Equals(input.Explanation))
                ) && 
                (
                    this.HomeCounselingGeneratedDate == input.HomeCounselingGeneratedDate ||
                    (this.HomeCounselingGeneratedDate != null &&
                    this.HomeCounselingGeneratedDate.Equals(input.HomeCounselingGeneratedDate))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SelectedGUID != null)
                    hashCode = hashCode * 59 + this.SelectedGUID.GetHashCode();
                if (this.AgencyName != null)
                    hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                if (this.AgencyAddress != null)
                    hashCode = hashCode * 59 + this.AgencyAddress.GetHashCode();
                if (this.AgencyAddressCity != null)
                    hashCode = hashCode * 59 + this.AgencyAddressCity.GetHashCode();
                if (this.AgencyAddressState != null)
                    hashCode = hashCode * 59 + this.AgencyAddressState.GetHashCode();
                if (this.AgencyAddressPostalCode != null)
                    hashCode = hashCode * 59 + this.AgencyAddressPostalCode.GetHashCode();
                if (this.AgencyPhoneDirect != null)
                    hashCode = hashCode * 59 + this.AgencyPhoneDirect.GetHashCode();
                if (this.AgencyPhoneTollFree != null)
                    hashCode = hashCode * 59 + this.AgencyPhoneTollFree.GetHashCode();
                if (this.AgencyFax != null)
                    hashCode = hashCode * 59 + this.AgencyFax.GetHashCode();
                if (this.AgencyEmail != null)
                    hashCode = hashCode * 59 + this.AgencyEmail.GetHashCode();
                if (this.AgencyWebAddress != null)
                    hashCode = hashCode * 59 + this.AgencyWebAddress.GetHashCode();
                if (this.LanguagesSupported != null)
                    hashCode = hashCode * 59 + this.LanguagesSupported.GetHashCode();
                if (this.CounselingServicesProvided != null)
                    hashCode = hashCode * 59 + this.CounselingServicesProvided.GetHashCode();
                if (this.AgencyAffiliationDescription != null)
                    hashCode = hashCode * 59 + this.AgencyAffiliationDescription.GetHashCode();
                if (this.HomeCounselingRequiredIndicator != null)
                    hashCode = hashCode * 59 + this.HomeCounselingRequiredIndicator.GetHashCode();
                if (this.HomeCounselingCompletionDate != null)
                    hashCode = hashCode * 59 + this.HomeCounselingCompletionDate.GetHashCode();
                if (this.CertificationIssuedIndicator != null)
                    hashCode = hashCode * 59 + this.CertificationIssuedIndicator.GetHashCode();
                if (this.HomeCounselingDisclosureDate != null)
                    hashCode = hashCode * 59 + this.HomeCounselingDisclosureDate.GetHashCode();
                if (this.DistanceMiles != null)
                    hashCode = hashCode * 59 + this.DistanceMiles.GetHashCode();
                if (this.AffiliatedWithLenderIndicator != null)
                    hashCode = hashCode * 59 + this.AffiliatedWithLenderIndicator.GetHashCode();
                if (this.BrrowerSelectCounselorIndicator != null)
                    hashCode = hashCode * 59 + this.BrrowerSelectCounselorIndicator.GetHashCode();
                if (this.Explanation != null)
                    hashCode = hashCode * 59 + this.Explanation.GetHashCode();
                if (this.HomeCounselingGeneratedDate != null)
                    hashCode = hashCode * 59 + this.HomeCounselingGeneratedDate.GetHashCode();
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
