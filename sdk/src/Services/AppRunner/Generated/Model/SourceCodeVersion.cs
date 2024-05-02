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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Identifies a version of code that App Runner refers to within a source code repository.
    /// </summary>
    public partial class SourceCodeVersion
    {
        private SourceCodeVersionType _type;
        private string _value;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of version identifier.
        /// </para>
        ///  
        /// <para>
        /// For a git-based repository, branches represent versions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceCodeVersionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// A source code version.
        /// </para>
        ///  
        /// <para>
        /// For a git-based repository, a branch name maps to a specific version. App Runner uses
        /// the most recent commit to the branch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=51200)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}