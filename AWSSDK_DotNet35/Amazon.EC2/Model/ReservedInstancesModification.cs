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
    /// <para>Describes a Reserved Instance modification.</para>
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
        /// A unique ID for the Reserved Instance modification.
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
        /// The IDs of one or more Reserved Instances.
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
        /// Contains target configurations along with their corresponding new Reserved Instance IDs.
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
        /// The time when the modification request was created.
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
        /// The time when the modification request was last updated.
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
        /// The time for the modification to become effective.
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
        /// The status of the Reserved Instances modification request.
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
        /// A unique, case-sensitive key supplied by the client to ensure that the modification request is idempotent.
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
