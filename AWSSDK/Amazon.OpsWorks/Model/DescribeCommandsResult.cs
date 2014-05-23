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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeCommands</code> request.
    /// </summary>
    public partial class DescribeCommandsResult
    {
        private List<Command> _commands = new List<Command>();


        /// <summary>
        /// Gets and sets the property Commands. 
        /// <para>
        /// An array of <code>Command</code> objects that describe each of the specified commands.
        /// </para>
        /// </summary>
        public List<Command> Commands
        {
            get { return this._commands; }
            set { this._commands = value; }
        }

        /// <summary>
        /// Sets the Commands property
        /// </summary>
        /// <param name="commands">The values to add to the Commands collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCommandsResult WithCommands(params Command[] commands)
        {
            foreach (var element in commands)
            {
                this._commands.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Commands property
        /// </summary>
        /// <param name="commands">The values to add to the Commands collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCommandsResult WithCommands(IEnumerable<Command> commands)
        {
            foreach (var element in commands)
            {
                this._commands.Add(element);
            }
            return this;
        }
        // Check to see if Commands property is set
        internal bool IsSetCommands()
        {
            return this._commands != null && this._commands.Count > 0; 
        }

    }
}