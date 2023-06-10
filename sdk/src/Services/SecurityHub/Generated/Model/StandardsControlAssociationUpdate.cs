/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An array of requested updates to the enablement status of controls in specified standards.
    /// The objects in the array include a security control ID, the Amazon Resource Name (ARN)
    /// of the standard, the requested enablement status, and the reason for updating the
    /// enablement status.
    /// </summary>
    public partial class StandardsControlAssociationUpdate
    {
        private AssociationStatus _associationStatus;
        private string _securityControlId;
        private string _standardsArn;
        private string _updatedReason;

        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        /// The desired enablement status of the control in the standard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssociationStatus AssociationStatus
        {
            get { return this._associationStatus; }
            set { this._associationStatus = value; }
        }

        // Check to see if AssociationStatus property is set
        internal bool IsSetAssociationStatus()
        {
            return this._associationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityControlId. 
        /// <para>
        /// The unique identifier for the security control whose enablement status you want to
        /// update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecurityControlId
        {
            get { return this._securityControlId; }
            set { this._securityControlId = value; }
        }

        // Check to see if SecurityControlId property is set
        internal bool IsSetSecurityControlId()
        {
            return this._securityControlId != null;
        }

        /// <summary>
        /// Gets and sets the property StandardsArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the standard in which you want to update the control's
        /// enablement status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StandardsArn
        {
            get { return this._standardsArn; }
            set { this._standardsArn = value; }
        }

        // Check to see if StandardsArn property is set
        internal bool IsSetStandardsArn()
        {
            return this._standardsArn != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedReason. 
        /// <para>
        /// The reason for updating the control's enablement status in the standard.
        /// </para>
        /// </summary>
        public string UpdatedReason
        {
            get { return this._updatedReason; }
            set { this._updatedReason = value; }
        }

        // Check to see if UpdatedReason property is set
        internal bool IsSetUpdatedReason()
        {
            return this._updatedReason != null;
        }

    }
}