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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// This is the response object from the BatchGetFleets operation.
    /// </summary>
    public partial class BatchGetFleetsResponse : AmazonWebServiceResponse
    {
        private List<Fleet> _fleets = AWSConfigs.InitializeCollections ? new List<Fleet>() : null;
        private List<string> _fleetsNotFound = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Fleets. 
        /// <para>
        /// Information about the requested compute fleets.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<Fleet> Fleets
        {
            get { return this._fleets; }
            set { this._fleets = value; }
        }

        // Check to see if Fleets property is set
        internal bool IsSetFleets()
        {
            return this._fleets != null && (this._fleets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FleetsNotFound. 
        /// <para>
        /// The names of compute fleets for which information could not be found.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> FleetsNotFound
        {
            get { return this._fleetsNotFound; }
            set { this._fleetsNotFound = value; }
        }

        // Check to see if FleetsNotFound property is set
        internal bool IsSetFleetsNotFound()
        {
            return this._fleetsNotFound != null && (this._fleetsNotFound.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}