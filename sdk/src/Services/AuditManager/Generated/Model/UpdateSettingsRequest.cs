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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSettings operation.
    /// Updates AWS Audit Manager settings for the current user account.
    /// </summary>
    public partial class UpdateSettingsRequest : AmazonAuditManagerRequest
    {
        private AssessmentReportsDestination _defaultAssessmentReportsDestination;
        private List<Role> _defaultProcessOwners = new List<Role>();
        private string _kmsKey;
        private string _snsTopic;

        /// <summary>
        /// Gets and sets the property DefaultAssessmentReportsDestination. 
        /// <para>
        ///  The default storage destination for assessment reports. 
        /// </para>
        /// </summary>
        public AssessmentReportsDestination DefaultAssessmentReportsDestination
        {
            get { return this._defaultAssessmentReportsDestination; }
            set { this._defaultAssessmentReportsDestination = value; }
        }

        // Check to see if DefaultAssessmentReportsDestination property is set
        internal bool IsSetDefaultAssessmentReportsDestination()
        {
            return this._defaultAssessmentReportsDestination != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultProcessOwners. 
        /// <para>
        ///  A list of the default audit owners. 
        /// </para>
        /// </summary>
        public List<Role> DefaultProcessOwners
        {
            get { return this._defaultProcessOwners; }
            set { this._defaultProcessOwners = value; }
        }

        // Check to see if DefaultProcessOwners property is set
        internal bool IsSetDefaultProcessOwners()
        {
            return this._defaultProcessOwners != null && this._defaultProcessOwners.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        ///  The AWS KMS key details. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=2048)]
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopic. 
        /// <para>
        ///  The Amazon Simple Notification Service (Amazon SNS) topic to which AWS Audit Manager
        /// sends notifications. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string SnsTopic
        {
            get { return this._snsTopic; }
            set { this._snsTopic = value; }
        }

        // Check to see if SnsTopic property is set
        internal bool IsSetSnsTopic()
        {
            return this._snsTopic != null;
        }

    }
}