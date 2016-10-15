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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Describes the solution stack.
    /// </summary>
    public partial class SolutionStackDescription
    {
        private List<string> _permittedFileTypes = new List<string>();
        private string _solutionStackName;

        /// <summary>
        /// Gets and sets the property PermittedFileTypes. 
        /// <para>
        /// The permitted file types allowed for a solution stack.
        /// </para>
        /// </summary>
        public List<string> PermittedFileTypes
        {
            get { return this._permittedFileTypes; }
            set { this._permittedFileTypes = value; }
        }

        // Check to see if PermittedFileTypes property is set
        internal bool IsSetPermittedFileTypes()
        {
            return this._permittedFileTypes != null && this._permittedFileTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SolutionStackName. 
        /// <para>
        /// The name of the solution stack.
        /// </para>
        /// </summary>
        public string SolutionStackName
        {
            get { return this._solutionStackName; }
            set { this._solutionStackName = value; }
        }

        // Check to see if SolutionStackName property is set
        internal bool IsSetSolutionStackName()
        {
            return this._solutionStackName != null;
        }

    }
}