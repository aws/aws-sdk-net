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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
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
namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Container for the parameters to the ListMicrovmImageBuilds operation.
    /// Lists builds for a MicroVM image version with optional filtering by architecture and
    /// chipset. We recommend using pagination to ensure that the operation returns quickly
    /// and successfully.
    /// </summary>
    public partial class ListMicrovmImageBuildsRequest : AmazonLambdaMicrovmsRequest
    {
        private Architecture _architecture;
        private Chipset _chipset;
        private string _chipsetGeneration;
        private string _imageIdentifier;
        private string _imageVersion;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// Filters builds by target CPU architecture.
        /// </para>
        /// </summary>
        public Architecture Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property Chipset. 
        /// <para>
        /// Filters builds by target chipset.
        /// </para>
        /// </summary>
        public Chipset Chipset
        {
            get { return this._chipset; }
            set { this._chipset = value; }
        }

        // Check to see if Chipset property is set
        internal bool IsSetChipset()
        {
            return this._chipset != null;
        }

        /// <summary>
        /// Gets and sets the property ChipsetGeneration. 
        /// <para>
        /// Filters builds by target chipset generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ChipsetGeneration
        {
            get { return this._chipsetGeneration; }
            set { this._chipsetGeneration = value; }
        }

        // Check to see if ChipsetGeneration property is set
        internal bool IsSetChipsetGeneration()
        {
            return this._chipsetGeneration != null;
        }

        /// <summary>
        /// Gets and sets the property ImageIdentifier. 
        /// <para>
        /// The unique identifier (ARN or ID) of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ImageIdentifier
        {
            get { return this._imageIdentifier; }
            set { this._imageIdentifier = value; }
        }

        // Check to see if ImageIdentifier property is set
        internal bool IsSetImageIdentifier()
        {
            return this._imageIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ImageVersion. 
        /// <para>
        /// The version of the MicroVM image to list builds for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ImageVersion
        {
            get { return this._imageVersion; }
            set { this._imageVersion = value; }
        }

        // Check to see if ImageVersion property is set
        internal bool IsSetImageVersion()
        {
            return this._imageVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token from a previous call. Use this token to retrieve the next page
        /// of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}