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
 * Do not modify this file. This file is generated from the supportauthz-2026-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SupportAuthZ.Model
{
    /// <summary>
    /// A summary of a support permit.
    /// </summary>
    public partial class SupportPermitSummary
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _name;
        private Permit _permit;
        private SigningKeyInfo _signingKeyInfo;
        private SupportPermitStatus _status;
        private string _supportCaseDisplayId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the support permit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the permit was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the support permit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Permit. 
        /// <para>
        /// The permit definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Permit Permit
        {
            get { return this._permit; }
            set { this._permit = value; }
        }

        // Check to see if Permit property is set
        internal bool IsSetPermit()
        {
            return this._permit != null;
        }

        /// <summary>
        /// Gets and sets the property SigningKeyInfo. 
        /// <para>
        /// The signing key information for the permit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SigningKeyInfo SigningKeyInfo
        {
            get { return this._signingKeyInfo; }
            set { this._signingKeyInfo = value; }
        }

        // Check to see if SigningKeyInfo property is set
        internal bool IsSetSigningKeyInfo()
        {
            return this._signingKeyInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the support permit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SupportPermitStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SupportCaseDisplayId. 
        /// <para>
        /// The display identifier of the support case associated with the permit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string SupportCaseDisplayId
        {
            get { return this._supportCaseDisplayId; }
            set { this._supportCaseDisplayId = value; }
        }

        // Check to see if SupportCaseDisplayId property is set
        internal bool IsSetSupportCaseDisplayId()
        {
            return this._supportCaseDisplayId != null;
        }

    }
}