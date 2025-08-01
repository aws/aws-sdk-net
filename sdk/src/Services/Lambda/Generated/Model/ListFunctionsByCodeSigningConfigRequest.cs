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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the ListFunctionsByCodeSigningConfig operation.
    /// List the functions that use the specified code signing configuration. You can use
    /// this method prior to deleting a code signing configuration, to verify that no functions
    /// are using it.
    /// </summary>
    public partial class ListFunctionsByCodeSigningConfigRequest : AmazonLambdaRequest
    {
        private string _codeSigningConfigArn;
        private string _marker;
        private int? _maxItems;

        /// <summary>
        /// Gets and sets the property CodeSigningConfigArn. 
        /// <para>
        /// The The Amazon Resource Name (ARN) of the code signing configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public string CodeSigningConfigArn
        {
            get { return this._codeSigningConfigArn; }
            set { this._codeSigningConfigArn = value; }
        }

        // Check to see if CodeSigningConfigArn property is set
        internal bool IsSetCodeSigningConfigArn()
        {
            return this._codeSigningConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Specify the pagination token that's returned by a previous request to retrieve the
        /// next page of results.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Maximum number of items to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}