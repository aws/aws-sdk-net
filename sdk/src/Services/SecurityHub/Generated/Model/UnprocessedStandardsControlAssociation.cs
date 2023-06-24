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
    /// Provides details about which control's enablement status couldn't be retrieved in
    /// a specified standard when calling <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchUpdateStandardsControlAssociations.html">BatchUpdateStandardsControlAssociations</a>.
    /// This parameter also provides details about why the request was unprocessed.
    /// </summary>
    public partial class UnprocessedStandardsControlAssociation
    {
        private UnprocessedErrorCode _errorCode;
        private string _errorReason;
        private StandardsControlAssociationId _standardsControlAssociationId;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code for the unprocessed standard and control association. 
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
        /// The reason why the standard and control association was unprocessed. 
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
        /// Gets and sets the property StandardsControlAssociationId. 
        /// <para>
        ///  An array with one or more objects that includes a security control (identified with
        /// <code>SecurityControlId</code>, <code>SecurityControlArn</code>, or a mix of both
        /// parameters) and the Amazon Resource Name (ARN) of a standard. This parameter shows
        /// the specific controls for which the enablement status couldn't be retrieved in specified
        /// standards when calling <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchUpdateStandardsControlAssociations.html">BatchUpdateStandardsControlAssociations</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StandardsControlAssociationId StandardsControlAssociationId
        {
            get { return this._standardsControlAssociationId; }
            set { this._standardsControlAssociationId = value; }
        }

        // Check to see if StandardsControlAssociationId property is set
        internal bool IsSetStandardsControlAssociationId()
        {
            return this._standardsControlAssociationId != null;
        }

    }
}