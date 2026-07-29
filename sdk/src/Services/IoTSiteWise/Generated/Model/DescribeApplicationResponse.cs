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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeApplication operation.
    /// </summary>
    public partial class DescribeApplicationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _description;
        private string _dnsSubdomain;
        private string _id;
        private string _idcApplicationArn;
        private string _name;
        private ApplicationStatus _status;
        private DateTime? _updatedAt;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of the application
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
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
        /// Timestamp when the application was created
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the application
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DnsSubdomain. 
        /// <para>
        /// DNS subdomain for the application
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string DnsSubdomain
        {
            get { return this._dnsSubdomain; }
            set { this._dnsSubdomain = value; }
        }

        // Check to see if DnsSubdomain property is set
        internal bool IsSetDnsSubdomain()
        {
            return this._dnsSubdomain != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Unique identifier of the application
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IdcApplicationArn. 
        /// <para>
        /// Identity Center Application ARN associated with this application
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string IdcApplicationArn
        {
            get { return this._idcApplicationArn; }
            set { this._idcApplicationArn = value; }
        }

        // Check to see if IdcApplicationArn property is set
        internal bool IsSetIdcApplicationArn()
        {
            return this._idcApplicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the application
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the application
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApplicationStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp when the application was last updated
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

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// Name of the workspace this application belongs to
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}