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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// A complex type that contains settings for an existing Resolver on an Outpost.
    /// </summary>
    public partial class OutpostResolver
    {
        private string _arn;
        private string _creationTime;
        private string _creatorRequestId;
        private string _id;
        private int? _instanceCount;
        private string _modificationTime;
        private string _name;
        private string _outpostArn;
        private string _preferredInstanceType;
        private OutpostResolverStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the Resolver on an Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the Outpost Resolver was created, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=40)]
        public string CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime != null;
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request that created the Resolver endpoint. The
        /// <c>CreatorRequestId</c> allows failed requests to be retried without the risk of running
        /// the operation twice.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the Resolver on Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// Amazon EC2 instance count for the Resolver on the Outpost.
        /// </para>
        /// </summary>
        public int? InstanceCount
        {
            get { return this._instanceCount; }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModificationTime. 
        /// <para>
        /// The date and time that the Outpost Resolver was modified, in Unix time format and
        /// Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=40)]
        public string ModificationTime
        {
            get { return this._modificationTime; }
            set { this._modificationTime = value; }
        }

        // Check to see if ModificationTime property is set
        internal bool IsSetModificationTime()
        {
            return this._modificationTime != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the Resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) for the Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredInstanceType. 
        /// <para>
        ///  The Amazon EC2 instance type. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PreferredInstanceType
        {
            get { return this._preferredInstanceType; }
            set { this._preferredInstanceType = value; }
        }

        // Check to see if PreferredInstanceType property is set
        internal bool IsSetPreferredInstanceType()
        {
            return this._preferredInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the Resolver.
        /// </para>
        /// </summary>
        public OutpostResolverStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed description of the Resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}