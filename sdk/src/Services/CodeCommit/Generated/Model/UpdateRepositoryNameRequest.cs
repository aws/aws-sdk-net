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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRepositoryName operation.
    /// Renames a repository. The repository name must be unique across the calling Amazon
    /// Web Services account. Repository names are limited to 100 alphanumeric, dash, and
    /// underscore characters, and cannot include certain characters. The suffix .git is prohibited.
    /// For more information about the limits on repository names, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Quotas</a>
    /// in the CodeCommit User Guide.
    /// </summary>
    public partial class UpdateRepositoryNameRequest : AmazonCodeCommitRequest
    {
        private string _newName;
        private string _oldName;

        /// <summary>
        /// Gets and sets the property NewName. 
        /// <para>
        /// The new name for the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string NewName
        {
            get { return this._newName; }
            set { this._newName = value; }
        }

        // Check to see if NewName property is set
        internal bool IsSetNewName()
        {
            return this._newName != null;
        }

        /// <summary>
        /// Gets and sets the property OldName. 
        /// <para>
        /// The current name of the repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string OldName
        {
            get { return this._oldName; }
            set { this._oldName = value; }
        }

        // Check to see if OldName property is set
        internal bool IsSetOldName()
        {
            return this._oldName != null;
        }

    }
}