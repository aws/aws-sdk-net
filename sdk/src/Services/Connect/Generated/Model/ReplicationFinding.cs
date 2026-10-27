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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about a resource that could not be replicated across the Regions
    /// of a Global Resiliency deployment, including the reason and any action required to
    /// resolve it.
    /// </summary>
    public partial class ReplicationFinding
    {
        private string _arn;
        private string _id;
        private string _message;
        private string _name;
        private string _operation;
        private string _referenceCode;
        private string _region;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that the finding is for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the resource that the finding is for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
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
        /// Gets and sets the property Message. 
        /// <para>
        /// A human-readable description of the finding and the action, if any, required to resolve
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the resource that the finding is for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Gets and sets the property Operation. 
        /// <para>
        /// The replication operation that produced the finding, such as a create, update, or
        /// delete of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceCode. 
        /// <para>
        /// A stable code that identifies the class of the finding. Use this code to look up the
        /// recommended steps to resolve the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ReferenceCode
        {
            get { return this._referenceCode; }
            set { this._referenceCode = value; }
        }

        // Check to see if ReferenceCode property is set
        internal bool IsSetReferenceCode()
        {
            return this._referenceCode != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region that the finding was detected in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=31)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource that the finding is for, such as <c>QUEUE</c> or <c>ROUTING_PROFILE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}