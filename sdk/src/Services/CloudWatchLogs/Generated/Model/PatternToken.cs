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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// A structure that contains information about one pattern token related to an anomaly.
    /// 
    ///  
    /// <para>
    /// For more information about patterns and tokens, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateLogAnomalyDetector.html">CreateLogAnomalyDetector</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class PatternToken
    {
        private int? _dynamicTokenPosition;
        private Dictionary<string, long> _enumerations = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;
        private string _inferredTokenName;
        private bool? _isDynamic;
        private string _tokenString;

        /// <summary>
        /// Gets and sets the property DynamicTokenPosition. 
        /// <para>
        /// For a dynamic token, this indicates where in the pattern that this token appears,
        /// related to other dynamic tokens. The dynamic token that appears first has a value
        /// of <c>1</c>, the one that appears second is <c>2</c>, and so on.
        /// </para>
        /// </summary>
        public int? DynamicTokenPosition
        {
            get { return this._dynamicTokenPosition; }
            set { this._dynamicTokenPosition = value; }
        }

        // Check to see if DynamicTokenPosition property is set
        internal bool IsSetDynamicTokenPosition()
        {
            return this._dynamicTokenPosition.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enumerations. 
        /// <para>
        /// Contains the values found for a dynamic token, and the number of times each value
        /// was found.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, long> Enumerations
        {
            get { return this._enumerations; }
            set { this._enumerations = value; }
        }

        // Check to see if Enumerations property is set
        internal bool IsSetEnumerations()
        {
            return this._enumerations != null && (this._enumerations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InferredTokenName. 
        /// <para>
        /// A name that CloudWatch Logs assigned to this dynamic token to make the pattern more
        /// readable. The string part of the <c>inferredTokenName</c> gives you a clearer idea
        /// of the content of this token. The number part of the <c>inferredTokenName</c> shows
        /// where in the pattern this token appears, compared to other dynamic tokens. CloudWatch
        /// Logs assigns the string part of the name based on analyzing the content of the log
        /// events that contain it.
        /// </para>
        ///  
        /// <para>
        /// For example, an inferred token name of <c>IPAddress-3</c> means that the token represents
        /// an IP address, and this token is the third dynamic token in the pattern.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string InferredTokenName
        {
            get { return this._inferredTokenName; }
            set { this._inferredTokenName = value; }
        }

        // Check to see if InferredTokenName property is set
        internal bool IsSetInferredTokenName()
        {
            return this._inferredTokenName != null;
        }

        /// <summary>
        /// Gets and sets the property IsDynamic. 
        /// <para>
        /// Specifies whether this is a dynamic token.
        /// </para>
        /// </summary>
        public bool? IsDynamic
        {
            get { return this._isDynamic; }
            set { this._isDynamic = value; }
        }

        // Check to see if IsDynamic property is set
        internal bool IsSetIsDynamic()
        {
            return this._isDynamic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TokenString. 
        /// <para>
        /// The string represented by this token. If this is a dynamic token, the value will be
        /// <c>&lt;*&gt;</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string TokenString
        {
            get { return this._tokenString; }
            set { this._tokenString = value; }
        }

        // Check to see if TokenString property is set
        internal bool IsSetTokenString()
        {
            return this._tokenString != null;
        }

    }
}