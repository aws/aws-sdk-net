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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A summary of a flow, including its ARN, Availability Zone, and source type.
    /// </summary>
    public partial class ListedFlow
    {
        private string _availabilityZone;
        private string _description;
        private string _flowArn;
        private Maintenance _maintenance;
        private string _name;
        private SourceType _sourceType;
        private Status _status;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///  The Availability Zone that the flow was created in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The ARN of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowArn
        {
            get { return this._flowArn; }
            set { this._flowArn = value; }
        }

        // Check to see if FlowArn property is set
        internal bool IsSetFlowArn()
        {
            return this._flowArn != null;
        }

        /// <summary>
        /// Gets and sets the property Maintenance. 
        /// <para>
        ///  The maintenance settings for the flow. 
        /// </para>
        /// </summary>
        public Maintenance Maintenance
        {
            get { return this._maintenance; }
            set { this._maintenance = value; }
        }

        // Check to see if Maintenance property is set
        internal bool IsSetMaintenance()
        {
            return this._maintenance != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SourceType. 
        /// <para>
        ///  The type of source. This value is either owned (originated somewhere other than an
        /// MediaConnect flow owned by another Amazon Web Services account) or entitled (originated
        /// at a MediaConnect flow owned by another Amazon Web Services account).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}