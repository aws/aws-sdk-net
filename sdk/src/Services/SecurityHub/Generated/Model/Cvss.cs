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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// CVSS scores from the advisory related to the vulnerability.
    /// </summary>
    public partial class Cvss
    {
        private List<Adjustment> _adjustments = AWSConfigs.InitializeCollections ? new List<Adjustment>() : null;
        private double? _baseScore;
        private string _baseVector;
        private string _source;
        private string _version;

        /// <summary>
        /// Gets and sets the property Adjustments. 
        /// <para>
        /// Adjustments to the CVSS metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Adjustment> Adjustments
        {
            get { return this._adjustments; }
            set { this._adjustments = value; }
        }

        // Check to see if Adjustments property is set
        internal bool IsSetAdjustments()
        {
            return this._adjustments != null && (this._adjustments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BaseScore. 
        /// <para>
        /// The base CVSS score.
        /// </para>
        /// </summary>
        public double? BaseScore
        {
            get { return this._baseScore; }
            set { this._baseScore = value; }
        }

        // Check to see if BaseScore property is set
        internal bool IsSetBaseScore()
        {
            return this._baseScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BaseVector. 
        /// <para>
        /// The base scoring vector for the CVSS score.
        /// </para>
        /// </summary>
        public string BaseVector
        {
            get { return this._baseVector; }
            set { this._baseVector = value; }
        }

        // Check to see if BaseVector property is set
        internal bool IsSetBaseVector()
        {
            return this._baseVector != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The origin of the original CVSS score and vector.
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of CVSS for the CVSS score.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}