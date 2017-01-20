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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAlias operation.
    /// Creates an alias for a directory and assigns the alias to the directory. The alias
    /// is used to construct the access URL for the directory, such as <code>http://&lt;alias&gt;.awsapps.com</code>.
    /// 
    ///  <important> 
    /// <para>
    /// After an alias has been created, it cannot be deleted or reused, so this operation
    /// should only be used when absolutely necessary.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateAliasRequest : AmazonDirectoryServiceRequest
    {
        private string _alias;
        private string _directoryId;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The requested alias.
        /// </para>
        ///  
        /// <para>
        /// The alias must be unique amongst all aliases in AWS. This operation throws an <code>EntityAlreadyExistsException</code>
        /// error if the alias already exists.
        /// </para>
        /// </summary>
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory for which to create the alias.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

    }
}