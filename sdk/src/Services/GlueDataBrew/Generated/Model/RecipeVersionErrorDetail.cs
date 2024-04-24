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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents any errors encountered when attempting to delete multiple recipe versions.
    /// </summary>
    public partial class RecipeVersionErrorDetail
    {
        private string _errorCode;
        private string _errorMessage;
        private string _recipeVersion;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The HTTP status code for the error.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The text of the error message.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property RecipeVersion. 
        /// <para>
        /// The identifier for the recipe version associated with this error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public string RecipeVersion
        {
            get { return this._recipeVersion; }
            set { this._recipeVersion = value; }
        }

        // Check to see if RecipeVersion property is set
        internal bool IsSetRecipeVersion()
        {
            return this._recipeVersion != null;
        }

    }
}