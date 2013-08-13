/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribeCommands</c> request.</para>
    /// </summary>
    public class DescribeCommandsResult
    {
        
        private List<Command> commands = new List<Command>();

        /// <summary>
        /// An array of <c>Command</c> objects that describe each of the specified commands.
        ///  
        /// </summary>
        public List<Command> Commands
        {
            get { return this.commands; }
            set { this.commands = value; }
        }
        /// <summary>
        /// Adds elements to the Commands collection
        /// </summary>
        /// <param name="commands">The values to add to the Commands collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCommandsResult WithCommands(params Command[] commands)
        {
            foreach (Command element in commands)
            {
                this.commands.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Commands collection
        /// </summary>
        /// <param name="commands">The values to add to the Commands collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeCommandsResult WithCommands(IEnumerable<Command> commands)
        {
            foreach (Command element in commands)
            {
                this.commands.Add(element);
            }

            return this;
        }

        // Check to see if Commands property is set
        internal bool IsSetCommands()
        {
            return this.commands.Count > 0;
        }
    }
}
