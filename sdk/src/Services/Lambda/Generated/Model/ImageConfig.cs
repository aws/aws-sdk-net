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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Configuration values that override the container image Dockerfile settings. For more
    /// information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/images-create.html#images-parms">Container
    /// image settings</a>.
    /// </summary>
    public partial class ImageConfig
    {
        private List<string> _command = new List<string>();
        private List<string> _entryPoint = new List<string>();
        private string _workingDirectory;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// Specifies parameters that you want to pass in with ENTRYPOINT.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1500)]
        public List<string> Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        /// <summary>
        /// This property is set to true if the property <seealso cref="Command"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsCommandSet
        {
            get
            {
                return Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._command);
            }
            set
            {
                Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._command);
            }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this.IsCommandSet; 
        }

        /// <summary>
        /// Gets and sets the property EntryPoint. 
        /// <para>
        /// Specifies the entry point to their application, which is typically the location of
        /// the runtime executable.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1500)]
        public List<string> EntryPoint
        {
            get { return this._entryPoint; }
            set { this._entryPoint = value; }
        }

        /// <summary>
        /// This property is set to true if the property <seealso cref="EntryPoint"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsEntryPointSet
        {
            get
            {
                return Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._entryPoint);
            }
            set
            {
                Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._entryPoint);
            }
        }

        // Check to see if EntryPoint property is set
        internal bool IsSetEntryPoint()
        {
            return this.IsEntryPointSet; 
        }

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// Specifies the working directory.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string WorkingDirectory
        {
            get { return this._workingDirectory; }
            set { this._workingDirectory = value; }
        }

        // Check to see if WorkingDirectory property is set
        internal bool IsSetWorkingDirectory()
        {
            return this._workingDirectory != null;
        }

    }
}