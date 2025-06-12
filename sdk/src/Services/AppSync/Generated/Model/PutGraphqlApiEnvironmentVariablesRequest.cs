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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Container for the parameters to the PutGraphqlApiEnvironmentVariables operation.
    /// Creates a list of environmental variables in an API by its ID value. 
    /// 
    ///  
    /// <para>
    /// When creating an environmental variable, it must follow the constraints below:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Both JavaScript and VTL templates support environmental variables.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Environmental variables are not evaluated before function invocation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Environmental variables only support string values.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Any defined value in an environmental variable is considered a string literal and
    /// not expanded.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Variable evaluations should ideally be performed in the function code.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When creating an environmental variable key-value pair, it must follow the additional
    /// constraints below:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Keys must begin with a letter.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Keys must be at least two characters long.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Keys can only contain letters, numbers, and the underscore character (_).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Values can be up to 512 characters long.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can configure up to 50 key-value pairs in a GraphQL API.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can create a list of environmental variables by adding it to the <c>environmentVariables</c>
    /// payload as a list in the format <c>{"key1":"value1","key2":"value2", …}</c>. Note
    /// that each call of the <c>PutGraphqlApiEnvironmentVariables</c> action will result
    /// in the overwriting of the existing environmental variable list of that API. This means
    /// the existing environmental variables will be lost. To avoid this, you must include
    /// all existing and new environmental variables in the list each time you call this action.
    /// </para>
    /// </summary>
    public partial class PutGraphqlApiEnvironmentVariablesRequest : AmazonAppSyncRequest
    {
        private string _apiId;
        private Dictionary<string, string> _environmentVariables = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The ID of the API to which the environmental variable list will be written.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// The list of environmental variables to add to the API.
        /// </para>
        ///  
        /// <para>
        /// When creating an environmental variable key-value pair, it must follow the additional
        /// constraints below:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Keys must begin with a letter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys must be at least two characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Keys can only contain letters, numbers, and the underscore character (_).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Values can be up to 512 characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can configure up to 50 key-value pairs in a GraphQL API.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can create a list of environmental variables by adding it to the <c>environmentVariables</c>
        /// payload as a list in the format <c>{"key1":"value1","key2":"value2", …}</c>. Note
        /// that each call of the <c>PutGraphqlApiEnvironmentVariables</c> action will result
        /// in the overwriting of the existing environmental variable list of that API. This means
        /// the existing environmental variables will be lost. To avoid this, you must include
        /// all existing and new environmental variables in the list each time you call this action.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public Dictionary<string, string> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}