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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale of the source field. If you omit this, the default of <c>locale.ROOT</c>
        /// is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Locale { get; set; }

        /// <summary>
        /// Checks to see if the Locale property is set.
        /// </summary>
        internal bool IsSetLocale() => this.Locale != null;

        /// <summary>
        /// Gets and sets the property MatchPatterns. 
        /// <para>
        /// A list of patterns to match against the <c>source</c> field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public List<string> MatchPatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MatchPatterns property is set.
        /// </summary>
        internal bool IsSetMatchPatterns() => this.MatchPatterns != null && (this.MatchPatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The key to apply the date conversion to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceTimezone. 
        /// <para>
        /// The time zone of the source field. If you omit this, the default used is the UTC zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string SourceTimezone { get; set; }

        /// <summary>
        /// Checks to see if the SourceTimezone property is set.
        /// </summary>
        internal bool IsSetSourceTimezone() => this.SourceTimezone != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The JSON field to store the result in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

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
        [AWSProperty(Min = 1, Max = 64)]
        public string TargetFormat { get; set; }

        /// <summary>
        /// Checks to see if the TargetFormat property is set.
        /// </summary>
        internal bool IsSetTargetFormat() => this.TargetFormat != null;

        /// <summary>
        /// Gets and sets the property TargetTimezone. 
        /// <para>
        /// The time zone of the target field. If you omit this, the default used is the UTC zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string TargetTimezone { get; set; }

        /// <summary>
        /// Checks to see if the TargetTimezone property is set.
        /// </summary>
        internal bool IsSetTargetTimezone() => this.TargetTimezone != null;
    }
}
