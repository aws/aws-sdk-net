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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
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
namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Captures detailed error information for EC2 instance operations.
    /// </summary>
    public partial class EC2InstanceError
    {
        private string _ec2ErrorCode;
        private string _ec2ErrorMessage;
        private string _ec2ExceptionType;

        /// <summary>
        /// Gets and sets the property EC2ErrorCode. 
        /// <para>
        /// Unique error code identifying the specific EC2 instance error.
        /// </para>
        /// </summary>
        public string EC2ErrorCode
        {
            get { return this._ec2ErrorCode; }
            set { this._ec2ErrorCode = value; }
        }

        // Check to see if EC2ErrorCode property is set
        internal bool IsSetEC2ErrorCode()
        {
            return this._ec2ErrorCode != null;
        }

        /// <summary>
        /// Gets and sets the property EC2ErrorMessage. 
        /// <para>
        /// Detailed description of the EC2 instance error.
        /// </para>
        /// </summary>
        public string EC2ErrorMessage
        {
            get { return this._ec2ErrorMessage; }
            set { this._ec2ErrorMessage = value; }
        }

        // Check to see if EC2ErrorMessage property is set
        internal bool IsSetEC2ErrorMessage()
        {
            return this._ec2ErrorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EC2ExceptionType. 
        /// <para>
        /// Type of exception encountered during EC2 instance operation.
        /// </para>
        /// </summary>
        public string EC2ExceptionType
        {
            get { return this._ec2ExceptionType; }
            set { this._ec2ExceptionType = value; }
        }

        // Check to see if EC2ExceptionType property is set
        internal bool IsSetEC2ExceptionType()
        {
            return this._ec2ExceptionType != null;
        }

    }
}