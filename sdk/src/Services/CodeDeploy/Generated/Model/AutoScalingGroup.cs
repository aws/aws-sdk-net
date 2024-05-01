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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about an Auto Scaling group.
    /// </summary>
    public partial class AutoScalingGroup
    {
        private string _hook;
        private string _name;
        private string _terminationHook;

        /// <summary>
        /// Gets and sets the property Hook. 
        /// <para>
        /// The name of the launch hook that CodeDeploy installed into the Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// For more information about the launch hook, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/integrations-aws-auto-scaling.html#integrations-aws-auto-scaling-behaviors">How
        /// Amazon EC2 Auto Scaling works with CodeDeploy</a> in the <i>CodeDeploy User Guide</i>.
        /// </para>
        /// </summary>
        public string Hook
        {
            get { return this._hook; }
            set { this._hook = value; }
        }

        // Check to see if Hook property is set
        internal bool IsSetHook()
        {
            return this._hook != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The Auto Scaling group name.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TerminationHook. 
        /// <para>
        /// The name of the termination hook that CodeDeploy installed into the Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// For more information about the termination hook, see <a href="https://docs.aws.amazon.com/codedeploy/latest/userguide/integrations-aws-auto-scaling.html#integrations-aws-auto-scaling-behaviors-hook-enable">Enabling
        /// termination deployments during Auto Scaling scale-in events</a> in the <i>CodeDeploy
        /// User Guide</i>.
        /// </para>
        /// </summary>
        public string TerminationHook
        {
            get { return this._terminationHook; }
            set { this._terminationHook = value; }
        }

        // Check to see if TerminationHook property is set
        internal bool IsSetTerminationHook()
        {
            return this._terminationHook != null;
        }

    }
}