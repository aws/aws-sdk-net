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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
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
namespace Amazon.CodeArtifact.Model
{
    /// <summary>
    /// Details about an allowed repository for a package group, including its name and origin
    /// configuration.
    /// </summary>
    public partial class PackageGroupAllowedRepository
    {
        private PackageGroupOriginRestrictionType _originRestrictionType;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property OriginRestrictionType. 
        /// <para>
        /// The origin configuration restriction type of the allowed repository.
        /// </para>
        /// </summary>
        public PackageGroupOriginRestrictionType OriginRestrictionType
        {
            get { return this._originRestrictionType; }
            set { this._originRestrictionType = value; }
        }

        // Check to see if OriginRestrictionType property is set
        internal bool IsSetOriginRestrictionType()
        {
            return this._originRestrictionType != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        ///  The name of the allowed repository. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}