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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the SignalResource operation.
    /// Sends a signal to the specified resource with a success or failure status. You can
    /// use the <c>SignalResource</c> operation in conjunction with a creation policy or update
    /// policy. CloudFormation doesn't proceed with a stack creation or update until resources
    /// receive the required number of signals or the timeout period is exceeded. The <c>SignalResource</c>
    /// operation is useful in cases where you want to send signals from anywhere other than
    /// an Amazon EC2 instance.
    /// </summary>
    public partial class SignalResourceRequest : AmazonCloudFormationRequest
    {
        private string _logicalResourceId;
        private string _stackName;
        private ResourceSignalStatus _status;
        private string _uniqueId;

        /// <summary>
        /// Gets and sets the property LogicalResourceId. 
        /// <para>
        /// The logical ID of the resource that you want to signal. The logical ID is the name
        /// of the resource that given in the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LogicalResourceId
        {
            get { return this._logicalResourceId; }
            set { this._logicalResourceId = value; }
        }

        // Check to see if LogicalResourceId property is set
        internal bool IsSetLogicalResourceId()
        {
            return this._logicalResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property StackName. 
        /// <para>
        /// The stack name or unique stack ID that includes the resource that you want to signal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string StackName
        {
            get { return this._stackName; }
            set { this._stackName = value; }
        }

        // Check to see if StackName property is set
        internal bool IsSetStackName()
        {
            return this._stackName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the signal, which is either success or failure. A failure signal causes
        /// CloudFormation to immediately fail the stack creation or update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceSignalStatus Status
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
        /// Gets and sets the property UniqueId. 
        /// <para>
        /// A unique ID of the signal. When you signal Amazon EC2 instances or Auto Scaling groups,
        /// specify the instance ID that you are signaling as the unique ID. If you send multiple
        /// signals to a single resource (such as signaling a wait condition), each signal requires
        /// a different unique ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string UniqueId
        {
            get { return this._uniqueId; }
            set { this._uniqueId = value; }
        }

        // Check to see if UniqueId property is set
        internal bool IsSetUniqueId()
        {
            return this._uniqueId != null;
        }

    }
}