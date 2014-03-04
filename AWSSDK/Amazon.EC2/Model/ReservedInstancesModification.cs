/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about a specific modification request to your Reserved Instances.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ReservedInstancesModification
    {
        
        private string reservedInstancesModificationIdField;
        private List<ReservedInstancesId> reservedInstancesIdsField;
        private List<ReservedInstancesModificationResult> modificationResultsField;
        private DateTime? createDateField;
        private DateTime? updateDateField;
        private DateTime? effectiveDateField;
        private string statusField;
        private string statusMessageField;
        private string clientTokenField;

        /// <summary>
        /// The unique ID for the submitted modification request.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesModificationId")]
        public string ReservedInstancesModificationId
        {
            get { return this.reservedInstancesModificationIdField; }
            set { this.reservedInstancesModificationIdField = value; }
        }

        // Check to see if ReservedInstancesModificationId property is set
        internal bool IsSetReservedInstancesModificationId()
        {
            return this.reservedInstancesModificationIdField != null;
        }

        /// <summary>
        /// The IDs of the Reserved Instances submitted for modification.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesId")]
        public List<ReservedInstancesId> ReservedInstancesIds
        {
            get
            {
                if (this.reservedInstancesIdsField == null)
                    this.reservedInstancesIdsField = new List<ReservedInstancesId>();
                return this.reservedInstancesIdsField;
            }
            set { this.reservedInstancesIdsField = value; }
        }

        // Check to see if ReservedInstancesIds property is set
        internal bool IsSetReservedInstancesIds()
        {
            return this.ReservedInstancesIds.Count > 0;
        }

        /// <summary>
        /// The resulting information about the modified Reserved Instances.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesModificationResult")]
        public List<ReservedInstancesModificationResult> ModificationResults
        {
            get
            {
                if (this.modificationResultsField == null)
                    this.modificationResultsField = new List<ReservedInstancesModificationResult>();
                return this.modificationResultsField; 
            }
            set { this.modificationResultsField = value; }
        }

        // Check to see if ModificationResults property is set
        internal bool IsSetModificationResults()
        {
            return this.ModificationResults.Count > 0;
        }

        /// <summary>
        /// The time the modification request was created.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreateDate")]
        public DateTime CreateDate
        {
            get { return this.createDateField.GetValueOrDefault(); }
            set { this.createDateField = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this.createDateField.HasValue;
        }

        /// <summary>
        /// The time the modification request was last updated.
        /// </summary>
        [XmlElementAttribute(ElementName = "UpdateDate")]
        public DateTime UpdateDate
        {
            get { return this.updateDateField.GetValueOrDefault(); }
            set { this.updateDateField = value; }
        }

        // Check to see if UpdateDate property is set
        internal bool IsSetUpdateDate()
        {
            return this.updateDateField.HasValue;
        }

        /// <summary>
        /// The time the modification becomes effective.
        /// </summary>
        [XmlElementAttribute(ElementName = "EffectiveDate")]
        public DateTime EffectiveDate
        {
            get { return this.effectiveDateField.GetValueOrDefault(); }
            set { this.effectiveDateField = value; }
        }

        // Check to see if EffectiveDate property is set
        internal bool IsSetEffectiveDate()
        {
            return this.effectiveDateField.HasValue;
        }

        /// <summary>
        /// The status of the modification request, which can be any of the following values: processing, fulfilled, failed.
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.statusField != null;
        }

        /// <summary>
        /// The reason for the status.
        /// </summary>
        [XmlElementAttribute(ElementName = "StatusMessage")]
        public string StatusMessage
        {
            get { return this.statusMessageField; }
            set { this.statusMessageField = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this.statusMessageField != null;
        }

        /// <summary>
        /// The idempotency token for the modification request.
        /// </summary>
        [XmlElementAttribute(ElementName = "ClientToken")]
        public string ClientToken
        {
            get { return this.clientTokenField; }
            set { this.clientTokenField = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this.clientTokenField != null;
        }
    }
}
