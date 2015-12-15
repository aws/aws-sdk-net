/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// A cross account destination that is the recipient of subscription log events.
    /// </summary>
    public partial class Destination
    {
        private string _accessPolicy;
        private string _arn;
        private long? _creationTime;
        private string _destinationName;
        private string _roleArn;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property AccessPolicy. 
        /// <para>
        /// An IAM policy document that governs which AWS accounts can create subscription filters
        /// against this destination.
        /// </para>
        /// </summary>
        public string AccessPolicy
        {
            get { return this._accessPolicy; }
            set { this._accessPolicy = value; }
        }

        // Check to see if AccessPolicy property is set
        internal bool IsSetAccessPolicy()
        {
            return this._accessPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of this destination.
        /// </para>
        /// </summary>
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
        /// A point in time expressed as the number of milliseconds since Jan 1, 1970 00:00:00
        /// UTC specifying when this destination was created.
        /// </para>
        /// </summary>
        public long CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// Name of the destination.
        /// </para>
        /// </summary>
        public string DestinationName
        {
            get { return this._destinationName; }
            set { this._destinationName = value; }
        }

        // Check to see if DestinationName property is set
        internal bool IsSetDestinationName()
        {
            return this._destinationName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// A role for impersonation for delivering log events to the target.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// ARN of the physical target where the log events will be delivered (eg. ARN of a Kinesis
        /// stream).
        /// </para>
        /// </summary>
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

    }
}