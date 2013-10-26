/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> Information about a specific modification request to your Reserved Instances. </para>
    /// </summary>
    public class ReservedInstancesModification
    {
        
        private string reservedInstancesModificationId;
        private List<ReservedInstancesId> reservedInstancesIds = new List<ReservedInstancesId>();
        private List<ReservedInstancesModificationResult> modificationResults = new List<ReservedInstancesModificationResult>();
        private DateTime? createDate;
        private DateTime? updateDate;
        private DateTime? effectiveDate;
        private string status;
        private string statusMessage;
        private string clientToken;


        /// <summary>
        /// The unique ID for the submitted modification request.
        ///  
        /// </summary>
        public string ReservedInstancesModificationId
        {
            get { return this.reservedInstancesModificationId; }
            set { this.reservedInstancesModificationId = value; }
        }

        // Check to see if ReservedInstancesModificationId property is set
        internal bool IsSetReservedInstancesModificationId()
        {
            return this.reservedInstancesModificationId != null;
        }

        /// <summary>
        /// The IDs of the Reserved Instances submitted for modification.
        ///  
        /// </summary>
        public List<ReservedInstancesId> ReservedInstancesIds
        {
            get { return this.reservedInstancesIds; }
            set { this.reservedInstancesIds = value; }
        }

        // Check to see if ReservedInstancesIds property is set
        internal bool IsSetReservedInstancesIds()
        {
            return this.reservedInstancesIds.Count > 0;
        }

        /// <summary>
        /// The resulting information about the modified Reserved Instances.
        ///  
        /// </summary>
        public List<ReservedInstancesModificationResult> ModificationResults
        {
            get { return this.modificationResults; }
            set { this.modificationResults = value; }
        }

        // Check to see if ModificationResults property is set
        internal bool IsSetModificationResults()
        {
            return this.modificationResults.Count > 0;
        }

        /// <summary>
        /// The time the modification request was created.
        ///  
        /// </summary>
        public DateTime CreateDate
        {
            get { return this.createDate ?? default(DateTime); }
            set { this.createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this.createDate.HasValue;
        }

        /// <summary>
        /// The time the modification request was last updated.
        ///  
        /// </summary>
        public DateTime UpdateDate
        {
            get { return this.updateDate ?? default(DateTime); }
            set { this.updateDate = value; }
        }

        // Check to see if UpdateDate property is set
        internal bool IsSetUpdateDate()
        {
            return this.updateDate.HasValue;
        }

        /// <summary>
        /// The time the modification becomes effective.
        ///  
        /// </summary>
        public DateTime EffectiveDate
        {
            get { return this.effectiveDate ?? default(DateTime); }
            set { this.effectiveDate = value; }
        }

        // Check to see if EffectiveDate property is set
        internal bool IsSetEffectiveDate()
        {
            return this.effectiveDate.HasValue;
        }

        /// <summary>
        /// The status of the modification request, which can be any of the following values: processing, fulfilled, failed.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The reason for the status.
        ///  
        /// </summary>
        public string StatusMessage
        {
            get { return this.statusMessage; }
            set { this.statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this.statusMessage != null;
        }

        /// <summary>
        /// The idempotency token for the modification request.
        ///  
        /// </summary>
        public string ClientToken
        {
            get { return this.clientToken; }
            set { this.clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this.clientToken != null;
        }
    }
}
