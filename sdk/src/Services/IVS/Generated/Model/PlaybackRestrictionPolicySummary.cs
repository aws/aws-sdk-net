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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
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
namespace Amazon.IVS.Model
{
    /// <summary>
    /// Summary information about a PlaybackRestrictionPolicy.
    /// </summary>
    public partial class PlaybackRestrictionPolicySummary
    {
        private List<string> _allowedCountries = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedOrigins = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _arn;
        private bool? _enableStrictOriginEnforcement;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AllowedCountries. 
        /// <para>
        /// A list of country codes that control geoblocking restriction. Allowed values are the
        /// officially assigned <a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a> codes. Default: All countries (an empty array).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AllowedCountries
        {
            get { return this._allowedCountries; }
            set { this._allowedCountries = value; }
        }

        // Check to see if AllowedCountries property is set
        internal bool IsSetAllowedCountries()
        {
            return this._allowedCountries != null && (this._allowedCountries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedOrigins. 
        /// <para>
        /// A list of origin sites that control CORS restriction. Allowed values are the same
        /// as valid values of the Origin header defined at <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Origin">https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Origin</a>.
        /// Default: All origins (an empty array).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AllowedOrigins
        {
            get { return this._allowedOrigins; }
            set { this._allowedOrigins = value; }
        }

        // Check to see if AllowedOrigins property is set
        internal bool IsSetAllowedOrigins()
        {
            return this._allowedOrigins != null && (this._allowedOrigins.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Playback-restriction-policy ARN
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property EnableStrictOriginEnforcement. 
        /// <para>
        /// Whether channel playback is constrained by origin site. Default: <c>false</c>.
        /// </para>
        /// </summary>
        public bool? EnableStrictOriginEnforcement
        {
            get { return this._enableStrictOriginEnforcement; }
            set { this._enableStrictOriginEnforcement = value; }
        }

        // Check to see if EnableStrictOriginEnforcement property is set
        internal bool IsSetEnableStrictOriginEnforcement()
        {
            return this._enableStrictOriginEnforcement.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Playback-restriction-policy name. The value does not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags attached to the resource. Array of 1-50 maps, each of the form <c>string:string
        /// (key:value)</c>. See <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/best-practices-and-strats.html">Best
        /// practices and strategies</a> in <i>Tagging Amazon Web Services Resources and Tag Editor</i>
        /// for details, including restrictions that apply to tags and "Tag naming limits and
        /// requirements"; Amazon IVS has no service-specific constraints beyond what is documented
        /// there.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}