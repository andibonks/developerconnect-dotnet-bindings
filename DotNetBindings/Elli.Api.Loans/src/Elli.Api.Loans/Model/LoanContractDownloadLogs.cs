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
    /// LoanContractDownloadLogs
    /// </summary>
    [DataContract]
    public partial class LoanContractDownloadLogs :  IEquatable<LoanContractDownloadLogs>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Alerts
        /// </summary>
        [DataMember(Name="alerts", EmitDefaultValue=false)]
        public List<LoanContractAlerts> Alerts { get; set; }

        /// <summary>
        /// Gets or Sets BarcodePage
        /// </summary>
        [DataMember(Name="barcodePage", EmitDefaultValue=false)]
        public string BarcodePage { get; set; }

        /// <summary>
        /// Gets or Sets CommentList
        /// </summary>
        [DataMember(Name="commentList", EmitDefaultValue=false)]
        public List<LoanContractLogRecordCommentList> CommentList { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets DateReceived
        /// </summary>
        [DataMember(Name="dateReceived", EmitDefaultValue=false)]
        public string DateReceived { get; set; }

        /// <summary>
        /// Gets or Sets DateUtc
        /// </summary>
        [DataMember(Name="dateUtc", EmitDefaultValue=false)]
        public DateTime? DateUtc { get; set; }

        /// <summary>
        /// Gets or Sets DocumentId
        /// </summary>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Gets or Sets DownloadId
        /// </summary>
        [DataMember(Name="downloadId", EmitDefaultValue=false)]
        public string DownloadId { get; set; }

        /// <summary>
        /// Gets or Sets FileAttachmentsMigrated
        /// </summary>
        [DataMember(Name="fileAttachmentsMigrated", EmitDefaultValue=false)]
        public bool? FileAttachmentsMigrated { get; set; }

        /// <summary>
        /// Gets or Sets FileSource
        /// </summary>
        [DataMember(Name="fileSource", EmitDefaultValue=false)]
        public string FileSource { get; set; }

        /// <summary>
        /// Gets or Sets FileType
        /// </summary>
        [DataMember(Name="fileType", EmitDefaultValue=false)]
        public string FileType { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets IsSystemSpecificIndicator
        /// </summary>
        [DataMember(Name="isSystemSpecificIndicator", EmitDefaultValue=false)]
        public bool? IsSystemSpecificIndicator { get; set; }

        /// <summary>
        /// Gets or Sets LogRecordIndex
        /// </summary>
        [DataMember(Name="logRecordIndex", EmitDefaultValue=false)]
        public int? LogRecordIndex { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedBy
        /// </summary>
        [DataMember(Name="receivedBy", EmitDefaultValue=false)]
        public string ReceivedBy { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// Gets or Sets SystemId
        /// </summary>
        [DataMember(Name="systemId", EmitDefaultValue=false)]
        public string SystemId { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractDownloadLogs {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Alerts: ").Append(Alerts).Append("\n");
            sb.Append("  BarcodePage: ").Append(BarcodePage).Append("\n");
            sb.Append("  CommentList: ").Append(CommentList).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  DateReceived: ").Append(DateReceived).Append("\n");
            sb.Append("  DateUtc: ").Append(DateUtc).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  DownloadId: ").Append(DownloadId).Append("\n");
            sb.Append("  FileAttachmentsMigrated: ").Append(FileAttachmentsMigrated).Append("\n");
            sb.Append("  FileSource: ").Append(FileSource).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  IsSystemSpecificIndicator: ").Append(IsSystemSpecificIndicator).Append("\n");
            sb.Append("  LogRecordIndex: ").Append(LogRecordIndex).Append("\n");
            sb.Append("  ReceivedBy: ").Append(ReceivedBy).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as LoanContractDownloadLogs);
        }

        /// <summary>
        /// Returns true if LoanContractDownloadLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractDownloadLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractDownloadLogs input)
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
                    this.Alerts == input.Alerts ||
                    this.Alerts != null &&
                    this.Alerts.SequenceEqual(input.Alerts)
                ) && 
                (
                    this.BarcodePage == input.BarcodePage ||
                    (this.BarcodePage != null &&
                    this.BarcodePage.Equals(input.BarcodePage))
                ) && 
                (
                    this.CommentList == input.CommentList ||
                    this.CommentList != null &&
                    this.CommentList.SequenceEqual(input.CommentList)
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.DateReceived == input.DateReceived ||
                    (this.DateReceived != null &&
                    this.DateReceived.Equals(input.DateReceived))
                ) && 
                (
                    this.DateUtc == input.DateUtc ||
                    (this.DateUtc != null &&
                    this.DateUtc.Equals(input.DateUtc))
                ) && 
                (
                    this.DocumentId == input.DocumentId ||
                    (this.DocumentId != null &&
                    this.DocumentId.Equals(input.DocumentId))
                ) && 
                (
                    this.DownloadId == input.DownloadId ||
                    (this.DownloadId != null &&
                    this.DownloadId.Equals(input.DownloadId))
                ) && 
                (
                    this.FileAttachmentsMigrated == input.FileAttachmentsMigrated ||
                    (this.FileAttachmentsMigrated != null &&
                    this.FileAttachmentsMigrated.Equals(input.FileAttachmentsMigrated))
                ) && 
                (
                    this.FileSource == input.FileSource ||
                    (this.FileSource != null &&
                    this.FileSource.Equals(input.FileSource))
                ) && 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.IsSystemSpecificIndicator == input.IsSystemSpecificIndicator ||
                    (this.IsSystemSpecificIndicator != null &&
                    this.IsSystemSpecificIndicator.Equals(input.IsSystemSpecificIndicator))
                ) && 
                (
                    this.LogRecordIndex == input.LogRecordIndex ||
                    (this.LogRecordIndex != null &&
                    this.LogRecordIndex.Equals(input.LogRecordIndex))
                ) && 
                (
                    this.ReceivedBy == input.ReceivedBy ||
                    (this.ReceivedBy != null &&
                    this.ReceivedBy.Equals(input.ReceivedBy))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Alerts != null)
                    hashCode = hashCode * 59 + this.Alerts.GetHashCode();
                if (this.BarcodePage != null)
                    hashCode = hashCode * 59 + this.BarcodePage.GetHashCode();
                if (this.CommentList != null)
                    hashCode = hashCode * 59 + this.CommentList.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.DateReceived != null)
                    hashCode = hashCode * 59 + this.DateReceived.GetHashCode();
                if (this.DateUtc != null)
                    hashCode = hashCode * 59 + this.DateUtc.GetHashCode();
                if (this.DocumentId != null)
                    hashCode = hashCode * 59 + this.DocumentId.GetHashCode();
                if (this.DownloadId != null)
                    hashCode = hashCode * 59 + this.DownloadId.GetHashCode();
                if (this.FileAttachmentsMigrated != null)
                    hashCode = hashCode * 59 + this.FileAttachmentsMigrated.GetHashCode();
                if (this.FileSource != null)
                    hashCode = hashCode * 59 + this.FileSource.GetHashCode();
                if (this.FileType != null)
                    hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.IsSystemSpecificIndicator != null)
                    hashCode = hashCode * 59 + this.IsSystemSpecificIndicator.GetHashCode();
                if (this.LogRecordIndex != null)
                    hashCode = hashCode * 59 + this.LogRecordIndex.GetHashCode();
                if (this.ReceivedBy != null)
                    hashCode = hashCode * 59 + this.ReceivedBy.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
