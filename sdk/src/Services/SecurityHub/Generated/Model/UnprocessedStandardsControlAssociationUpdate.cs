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
    /// Provides details about which control's enablement status could not be updated in a
    /// specified standard when calling the <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchUpdateStandardsControlAssociations.html">BatchUpdateStandardsControlAssociations</a>
    /// API. This parameter also provides details about why the request was unprocessed.
    /// </summary>
    public partial class UnprocessedStandardsControlAssociationUpdate
    {
        private UnprocessedErrorCode _errorCode;
        private string _errorReason;
        private StandardsControlAssociationUpdate _standardsControlAssociationUpdate;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code for the unprocessed update of the control's enablement status in the
        /// specified standard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UnprocessedErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorReason. 
        /// <para>
        /// The reason why a control's enablement status in the specified standard couldn't be
        /// updated. 
        /// </para>
        /// </summary>
        public string ErrorReason
        {
            get { return this._errorReason; }
            set { this._errorReason = value; }
        }

        // Check to see if ErrorReason property is set
        internal bool IsSetErrorReason()
        {
            return this._errorReason != null;
        }

        /// <summary>
        /// Gets and sets the property StandardsControlAssociationUpdate. 
        /// <para>
        /// An array of control and standard associations for which an update failed when calling
        /// <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchUpdateStandardsControlAssociations.html">BatchUpdateStandardsControlAssociations</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StandardsControlAssociationUpdate StandardsControlAssociationUpdate
        {
            get { return this._standardsControlAssociationUpdate; }
            set { this._standardsControlAssociationUpdate = value; }
        }

        // Check to see if StandardsControlAssociationUpdate property is set
        internal bool IsSetStandardsControlAssociationUpdate()
        {
            return this._standardsControlAssociationUpdate != null;
        }

    }
}