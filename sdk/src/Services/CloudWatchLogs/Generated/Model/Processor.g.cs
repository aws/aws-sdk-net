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
    /// This structure contains the information about one processor in a log transformer.
    /// </summary>
    public partial class Processor
    {
        /// <summary>
        /// Gets and sets the property AddKeys. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-addKeys">
        /// addKeys</a> processor in your transformer.
        /// </para>
        /// </summary>
        public AddKeys AddKeys { get; set; }

        /// <summary>
        /// Checks to see if the AddKeys property is set.
        /// </summary>
        internal bool IsSetAddKeys() => this.AddKeys != null;

        /// <summary>
        /// Gets and sets the property CopyValue. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-copyValue">
        /// copyValue</a> processor in your transformer.
        /// </para>
        /// </summary>
        public CopyValue CopyValue { get; set; }

        /// <summary>
        /// Checks to see if the CopyValue property is set.
        /// </summary>
        internal bool IsSetCopyValue() => this.CopyValue != null;

        /// <summary>
        /// Gets and sets the property Csv. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-CSV">
        /// CSV</a> processor in your transformer.
        /// </para>
        /// </summary>
        public CSV Csv { get; set; }

        /// <summary>
        /// Checks to see if the Csv property is set.
        /// </summary>
        internal bool IsSetCsv() => this.Csv != null;

        /// <summary>
        /// Gets and sets the property DateTimeConverter. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-datetimeConverter">
        /// datetimeConverter</a> processor in your transformer.
        /// </para>
        /// </summary>
        public DateTimeConverter DateTimeConverter { get; set; }

        /// <summary>
        /// Checks to see if the DateTimeConverter property is set.
        /// </summary>
        internal bool IsSetDateTimeConverter() => this.DateTimeConverter != null;

        /// <summary>
        /// Gets and sets the property DeleteKeys. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-deleteKeys">
        /// deleteKeys</a> processor in your transformer.
        /// </para>
        /// </summary>
        public DeleteKeys DeleteKeys { get; set; }

        /// <summary>
        /// Checks to see if the DeleteKeys property is set.
        /// </summary>
        internal bool IsSetDeleteKeys() => this.DeleteKeys != null;

        /// <summary>
        /// Gets and sets the property Grok. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-grok">
        /// grok</a> processor in your transformer.
        /// </para>
        /// </summary>
        public Grok Grok { get; set; }

        /// <summary>
        /// Checks to see if the Grok property is set.
        /// </summary>
        internal bool IsSetGrok() => this.Grok != null;

        /// <summary>
        /// Gets and sets the property ListToMap. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-listToMap">
        /// listToMap</a> processor in your transformer.
        /// </para>
        /// </summary>
        public ListToMap ListToMap { get; set; }

        /// <summary>
        /// Checks to see if the ListToMap property is set.
        /// </summary>
        internal bool IsSetListToMap() => this.ListToMap != null;

        /// <summary>
        /// Gets and sets the property LowerCaseString. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-lowerCaseString">
        /// lowerCaseString</a> processor in your transformer.
        /// </para>
        /// </summary>
        public LowerCaseString LowerCaseString { get; set; }

        /// <summary>
        /// Checks to see if the LowerCaseString property is set.
        /// </summary>
        internal bool IsSetLowerCaseString() => this.LowerCaseString != null;

        /// <summary>
        /// Gets and sets the property MoveKeys. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-moveKeys">
        /// moveKeys</a> processor in your transformer.
        /// </para>
        /// </summary>
        public MoveKeys MoveKeys { get; set; }

        /// <summary>
        /// Checks to see if the MoveKeys property is set.
        /// </summary>
        internal bool IsSetMoveKeys() => this.MoveKeys != null;

        /// <summary>
        /// Gets and sets the property ParseCloudfront. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-parseCloudfront">
        /// parseCloudfront</a> processor in your transformer.
        /// </para>
        ///  
        /// <para>
        /// If you use this processor, it must be the first processor in your transformer.
        /// </para>
        /// </summary>
        public ParseCloudfront ParseCloudfront { get; set; }

        /// <summary>
        /// Checks to see if the ParseCloudfront property is set.
        /// </summary>
        internal bool IsSetParseCloudfront() => this.ParseCloudfront != null;

        /// <summary>
        /// Gets and sets the property ParseJSON. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-parseJSON">
        /// parseJSON</a> processor in your transformer.
        /// </para>
        /// </summary>
        public ParseJSON ParseJSON { get; set; }

        /// <summary>
        /// Checks to see if the ParseJSON property is set.
        /// </summary>
        internal bool IsSetParseJSON() => this.ParseJSON != null;

        /// <summary>
        /// Gets and sets the property ParseKeyValue. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-parseKeyValue">
        /// parseKeyValue</a> processor in your transformer.
        /// </para>
        /// </summary>
        public ParseKeyValue ParseKeyValue { get; set; }

        /// <summary>
        /// Checks to see if the ParseKeyValue property is set.
        /// </summary>
        internal bool IsSetParseKeyValue() => this.ParseKeyValue != null;

        /// <summary>
        /// Gets and sets the property ParsePostgres. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-parsePostGres">
        /// parsePostGres</a> processor in your transformer.
        /// </para>
        ///  
        /// <para>
        /// If you use this processor, it must be the first processor in your transformer.
        /// </para>
        /// </summary>
        public ParsePostgres ParsePostgres { get; set; }

        /// <summary>
        /// Checks to see if the ParsePostgres property is set.
        /// </summary>
        internal bool IsSetParsePostgres() => this.ParsePostgres != null;

        /// <summary>
        /// Gets and sets the property ParseRoute53. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-parseRoute53">
        /// parseRoute53</a> processor in your transformer.
        /// </para>
        ///  
        /// <para>
        /// If you use this processor, it must be the first processor in your transformer.
        /// </para>
        /// </summary>
        public ParseRoute53 ParseRoute53 { get; set; }

        /// <summary>
        /// Checks to see if the ParseRoute53 property is set.
        /// </summary>
        internal bool IsSetParseRoute53() => this.ParseRoute53 != null;

        /// <summary>
        /// Gets and sets the property ParseToOCSF. 
        /// <para>
        /// Use this parameter to convert logs into Open Cybersecurity Schema (OCSF) format.
        /// </para>
        /// </summary>
        public ParseToOCSF ParseToOCSF { get; set; }

        /// <summary>
        /// Checks to see if the ParseToOCSF property is set.
        /// </summary>
        internal bool IsSetParseToOCSF() => this.ParseToOCSF != null;

        /// <summary>
        /// Gets and sets the property ParseVPC. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-parseVPC">
        /// parseVPC</a> processor in your transformer.
        /// </para>
        ///  
        /// <para>
        /// If you use this processor, it must be the first processor in your transformer.
        /// </para>
        /// </summary>
        public ParseVPC ParseVPC { get; set; }

        /// <summary>
        /// Checks to see if the ParseVPC property is set.
        /// </summary>
        internal bool IsSetParseVPC() => this.ParseVPC != null;

        /// <summary>
        /// Gets and sets the property ParseWAF. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-parseWAF">
        /// parseWAF</a> processor in your transformer.
        /// </para>
        ///  
        /// <para>
        /// If you use this processor, it must be the first processor in your transformer.
        /// </para>
        /// </summary>
        public ParseWAF ParseWAF { get; set; }

        /// <summary>
        /// Checks to see if the ParseWAF property is set.
        /// </summary>
        internal bool IsSetParseWAF() => this.ParseWAF != null;

        /// <summary>
        /// Gets and sets the property RenameKeys. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-renameKeys">
        /// renameKeys</a> processor in your transformer.
        /// </para>
        /// </summary>
        public RenameKeys RenameKeys { get; set; }

        /// <summary>
        /// Checks to see if the RenameKeys property is set.
        /// </summary>
        internal bool IsSetRenameKeys() => this.RenameKeys != null;

        /// <summary>
        /// Gets and sets the property SplitString. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-splitString">
        /// splitString</a> processor in your transformer.
        /// </para>
        /// </summary>
        public SplitString SplitString { get; set; }

        /// <summary>
        /// Checks to see if the SplitString property is set.
        /// </summary>
        internal bool IsSetSplitString() => this.SplitString != null;

        /// <summary>
        /// Gets and sets the property SubstituteString. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-substituteString">
        /// substituteString</a> processor in your transformer.
        /// </para>
        /// </summary>
        public SubstituteString SubstituteString { get; set; }

        /// <summary>
        /// Checks to see if the SubstituteString property is set.
        /// </summary>
        internal bool IsSetSubstituteString() => this.SubstituteString != null;

        /// <summary>
        /// Gets and sets the property TrimString. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-trimString">
        /// trimString</a> processor in your transformer.
        /// </para>
        /// </summary>
        public TrimString TrimString { get; set; }

        /// <summary>
        /// Checks to see if the TrimString property is set.
        /// </summary>
        internal bool IsSetTrimString() => this.TrimString != null;

        /// <summary>
        /// Gets and sets the property TypeConverter. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-typeConverter">
        /// typeConverter</a> processor in your transformer.
        /// </para>
        /// </summary>
        public TypeConverter TypeConverter { get; set; }

        /// <summary>
        /// Checks to see if the TypeConverter property is set.
        /// </summary>
        internal bool IsSetTypeConverter() => this.TypeConverter != null;

        /// <summary>
        /// Gets and sets the property UpperCaseString. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-upperCaseString">
        /// upperCaseString</a> processor in your transformer.
        /// </para>
        /// </summary>
        public UpperCaseString UpperCaseString { get; set; }

        /// <summary>
        /// Checks to see if the UpperCaseString property is set.
        /// </summary>
        internal bool IsSetUpperCaseString() => this.UpperCaseString != null;
    }
}
