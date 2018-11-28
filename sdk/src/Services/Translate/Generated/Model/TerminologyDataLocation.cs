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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Translate.Model
{
    /// <summary>
    /// The location of the custom terminology data.
    /// </summary>
    public partial class TerminologyDataLocation
    {
        private string _location;
        private string _repositoryType;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of the custom terminology data.
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryType. 
        /// <para>
        /// The repository type for the custom terminology data.
        /// </para>
        /// </summary>
        public string RepositoryType
        {
            get { return this._repositoryType; }
            set { this._repositoryType = value; }
        }

        // Check to see if RepositoryType property is set
        internal bool IsSetRepositoryType()
        {
            return this._repositoryType != null;
        }

    }
}