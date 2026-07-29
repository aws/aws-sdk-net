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
    /// A permit request from an AWS support operator.
    /// </summary>
    public partial class SupportPermitRequest
    {
        private DateTime? _createdAt;
        private Permit _permit;
        private string _requestArn;
        private SupportPermitRequestStatus _status;
        private string _supportCaseDisplayId;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the request was created.
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
        /// Gets and sets the property Permit. 
        /// <para>
        /// The permit definition requested by the operator.
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
        /// Gets and sets the property RequestArn. 
        /// <para>
        /// The ARN of the permit request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string RequestArn
        {
            get { return this._requestArn; }
            set { this._requestArn = value; }
        }

        // Check to see if RequestArn property is set
        internal bool IsSetRequestArn()
        {
            return this._requestArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the permit request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SupportPermitRequestStatus Status
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
        /// The display identifier of the support case associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the request was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}