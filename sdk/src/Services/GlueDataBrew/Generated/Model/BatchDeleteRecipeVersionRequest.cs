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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDeleteRecipeVersion operation.
    /// Deletes one or more versions of a recipe at a time.
    /// 
    ///  
    /// <para>
    /// The entire request will be rejected if:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The recipe does not exist.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// There is an invalid version identifier in the list of versions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The verision list is empty.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The version list size exceeds 50.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The verison list contains duplicate entries.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The request will complete successfully, but with partial failures, if:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A version does not exist.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A version is being used by a job.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You specify <code>LATEST_WORKING</code>, but it's being used by a project.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The version fails to be deleted.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The <code>LATEST_WORKING</code> version will only be deleted if the recipe has no
    /// other versions. If you try to delete <code>LATEST_WORKING</code> while other versions
    /// exist (or if they can't be deleted), then <code>LATEST_WORKING</code> will be listed
    /// as partial failure in the response.
    /// </para>
    /// </summary>
    public partial class BatchDeleteRecipeVersionRequest : AmazonGlueDataBrewRequest
    {
        private string _name;
        private List<string> _recipeVersions = new List<string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the recipe whose versions are to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RecipeVersions. 
        /// <para>
        /// An array of version identifiers, for the recipe versions to be deleted. You can specify
        /// numeric versions (<code>X.Y</code>) or <code>LATEST_WORKING</code>. <code>LATEST_PUBLISHED</code>
        /// is not supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> RecipeVersions
        {
            get { return this._recipeVersions; }
            set { this._recipeVersions = value; }
        }

        // Check to see if RecipeVersions property is set
        internal bool IsSetRecipeVersions()
        {
            return this._recipeVersions != null && this._recipeVersions.Count > 0; 
        }

    }
}