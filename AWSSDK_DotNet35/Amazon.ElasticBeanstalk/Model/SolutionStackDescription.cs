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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para> Describes the solution stack. </para>
    /// </summary>
    public class SolutionStackDescription
    {
        
        private string solutionStackName;
        private List<string> permittedFileTypes = new List<string>();

        /// <summary>
        /// The name of the solution stack.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string SolutionStackName
        {
            get { return this.solutionStackName; }
            set { this.solutionStackName = value; }
        }

        // Check to see if SolutionStackName property is set
        internal bool IsSetSolutionStackName()
        {
            return this.solutionStackName != null;
        }

        /// <summary>
        /// The permitted file types allowed for a solution stack.
        ///  
        /// </summary>
        public List<string> PermittedFileTypes
        {
            get { return this.permittedFileTypes; }
            set { this.permittedFileTypes = value; }
        }

        // Check to see if PermittedFileTypes property is set
        internal bool IsSetPermittedFileTypes()
        {
            return this.permittedFileTypes.Count > 0;
        }
    }
}
