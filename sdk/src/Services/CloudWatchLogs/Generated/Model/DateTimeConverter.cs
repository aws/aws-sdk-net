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
    /// This processor converts a datetime string into a format that you specify. 
    /// 
    ///  
    /// <para>
    /// For more information about this processor including examples, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-datetimeConverter">
    /// datetimeConverter</a> in the <i>CloudWatch Logs User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DateTimeConverter
    {
        private string _locale;
        private List<string> _matchPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _source;
        private string _sourceTimezone;
        private string _target;
        private string _targetFormat;
        private string _targetTimezone;

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale of the source field. If you omit this, the default of <c>locale.ROOT</c>
        /// is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

        /// <summary>
        /// Gets and sets the property MatchPatterns. 
        /// <para>
        /// A list of patterns to match against the <c>source</c> field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<string> MatchPatterns
        {
            get { return this._matchPatterns; }
            set { this._matchPatterns = value; }
        }

        // Check to see if MatchPatterns property is set
        internal bool IsSetMatchPatterns()
        {
            return this._matchPatterns != null && (this._matchPatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The key to apply the date conversion to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property SourceTimezone. 
        /// <para>
        /// The time zone of the source field. If you omit this, the default used is the UTC zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string SourceTimezone
        {
            get { return this._sourceTimezone; }
            set { this._sourceTimezone = value; }
        }

        // Check to see if SourceTimezone property is set
        internal bool IsSetSourceTimezone()
        {
            return this._sourceTimezone != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The JSON field to store the result in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property TargetFormat. 
        /// <para>
        /// The datetime format to use for the converted data in the target field.
        /// </para>
        ///  
        /// <para>
        /// If you omit this, the default of <c> yyyy-MM-dd'T'HH:mm:ss.SSS'Z</c> is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string TargetFormat
        {
            get { return this._targetFormat; }
            set { this._targetFormat = value; }
        }

        // Check to see if TargetFormat property is set
        internal bool IsSetTargetFormat()
        {
            return this._targetFormat != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTimezone. 
        /// <para>
        /// The time zone of the target field. If you omit this, the default used is the UTC zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string TargetTimezone
        {
            get { return this._targetTimezone; }
            set { this._targetTimezone = value; }
        }

        // Check to see if TargetTimezone property is set
        internal bool IsSetTargetTimezone()
        {
            return this._targetTimezone != null;
        }

    }
}