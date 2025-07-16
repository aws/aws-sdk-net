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
    /// This structure contains the information about one processor in a log transformer.
    /// </summary>
    public partial class Processor
    {
        private AddKeys _addKeys;
        private CopyValue _copyValue;
        private CSV _csv;
        private DateTimeConverter _dateTimeConverter;
        private DeleteKeys _deleteKeys;
        private Grok _grok;
        private ListToMap _listToMap;
        private LowerCaseString _lowerCaseString;
        private MoveKeys _moveKeys;
        private ParseCloudfront _parseCloudfront;
        private ParseJSON _parsejson;
        private ParseKeyValue _parseKeyValue;
        private ParsePostgres _parsePostgres;
        private ParseRoute53 _parseRoute53;
        private ParseToOCSF _parseToOCSF;
        private ParseVPC _parsevpc;
        private ParseWAF _parsewaf;
        private RenameKeys _renameKeys;
        private SplitString _splitString;
        private SubstituteString _substituteString;
        private TrimString _trimString;
        private TypeConverter _typeConverter;
        private UpperCaseString _upperCaseString;

        /// <summary>
        /// Gets and sets the property AddKeys. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-addKeys">
        /// addKeys</a> processor in your transformer.
        /// </para>
        /// </summary>
        public AddKeys AddKeys
        {
            get { return this._addKeys; }
            set { this._addKeys = value; }
        }

        // Check to see if AddKeys property is set
        internal bool IsSetAddKeys()
        {
            return this._addKeys != null;
        }

        /// <summary>
        /// Gets and sets the property CopyValue. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-copyValue">
        /// copyValue</a> processor in your transformer.
        /// </para>
        /// </summary>
        public CopyValue CopyValue
        {
            get { return this._copyValue; }
            set { this._copyValue = value; }
        }

        // Check to see if CopyValue property is set
        internal bool IsSetCopyValue()
        {
            return this._copyValue != null;
        }

        /// <summary>
        /// Gets and sets the property Csv. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-CSV">
        /// CSV</a> processor in your transformer.
        /// </para>
        /// </summary>
        public CSV Csv
        {
            get { return this._csv; }
            set { this._csv = value; }
        }

        // Check to see if Csv property is set
        internal bool IsSetCsv()
        {
            return this._csv != null;
        }

        /// <summary>
        /// Gets and sets the property DateTimeConverter. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-datetimeConverter">
        /// datetimeConverter</a> processor in your transformer.
        /// </para>
        /// </summary>
        public DateTimeConverter DateTimeConverter
        {
            get { return this._dateTimeConverter; }
            set { this._dateTimeConverter = value; }
        }

        // Check to see if DateTimeConverter property is set
        internal bool IsSetDateTimeConverter()
        {
            return this._dateTimeConverter != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteKeys. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-deleteKeys">
        /// deleteKeys</a> processor in your transformer.
        /// </para>
        /// </summary>
        public DeleteKeys DeleteKeys
        {
            get { return this._deleteKeys; }
            set { this._deleteKeys = value; }
        }

        // Check to see if DeleteKeys property is set
        internal bool IsSetDeleteKeys()
        {
            return this._deleteKeys != null;
        }

        /// <summary>
        /// Gets and sets the property Grok. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-grok">
        /// grok</a> processor in your transformer.
        /// </para>
        /// </summary>
        public Grok Grok
        {
            get { return this._grok; }
            set { this._grok = value; }
        }

        // Check to see if Grok property is set
        internal bool IsSetGrok()
        {
            return this._grok != null;
        }

        /// <summary>
        /// Gets and sets the property ListToMap. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-listToMap">
        /// listToMap</a> processor in your transformer.
        /// </para>
        /// </summary>
        public ListToMap ListToMap
        {
            get { return this._listToMap; }
            set { this._listToMap = value; }
        }

        // Check to see if ListToMap property is set
        internal bool IsSetListToMap()
        {
            return this._listToMap != null;
        }

        /// <summary>
        /// Gets and sets the property LowerCaseString. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-lowerCaseString">
        /// lowerCaseString</a> processor in your transformer.
        /// </para>
        /// </summary>
        public LowerCaseString LowerCaseString
        {
            get { return this._lowerCaseString; }
            set { this._lowerCaseString = value; }
        }

        // Check to see if LowerCaseString property is set
        internal bool IsSetLowerCaseString()
        {
            return this._lowerCaseString != null;
        }

        /// <summary>
        /// Gets and sets the property MoveKeys. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-moveKeys">
        /// moveKeys</a> processor in your transformer.
        /// </para>
        /// </summary>
        public MoveKeys MoveKeys
        {
            get { return this._moveKeys; }
            set { this._moveKeys = value; }
        }

        // Check to see if MoveKeys property is set
        internal bool IsSetMoveKeys()
        {
            return this._moveKeys != null;
        }

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
        public ParseCloudfront ParseCloudfront
        {
            get { return this._parseCloudfront; }
            set { this._parseCloudfront = value; }
        }

        // Check to see if ParseCloudfront property is set
        internal bool IsSetParseCloudfront()
        {
            return this._parseCloudfront != null;
        }

        /// <summary>
        /// Gets and sets the property ParseJSON. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-parseJSON">
        /// parseJSON</a> processor in your transformer.
        /// </para>
        /// </summary>
        public ParseJSON ParseJSON
        {
            get { return this._parsejson; }
            set { this._parsejson = value; }
        }

        // Check to see if ParseJSON property is set
        internal bool IsSetParseJSON()
        {
            return this._parsejson != null;
        }

        /// <summary>
        /// Gets and sets the property ParseKeyValue. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-parseKeyValue">
        /// parseKeyValue</a> processor in your transformer.
        /// </para>
        /// </summary>
        public ParseKeyValue ParseKeyValue
        {
            get { return this._parseKeyValue; }
            set { this._parseKeyValue = value; }
        }

        // Check to see if ParseKeyValue property is set
        internal bool IsSetParseKeyValue()
        {
            return this._parseKeyValue != null;
        }

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
        public ParsePostgres ParsePostgres
        {
            get { return this._parsePostgres; }
            set { this._parsePostgres = value; }
        }

        // Check to see if ParsePostgres property is set
        internal bool IsSetParsePostgres()
        {
            return this._parsePostgres != null;
        }

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
        public ParseRoute53 ParseRoute53
        {
            get { return this._parseRoute53; }
            set { this._parseRoute53 = value; }
        }

        // Check to see if ParseRoute53 property is set
        internal bool IsSetParseRoute53()
        {
            return this._parseRoute53 != null;
        }

        /// <summary>
        /// Gets and sets the property ParseToOCSF. 
        /// <para>
        /// Use this parameter to convert logs into Open Cybersecurity Schema (OCSF) format.
        /// </para>
        /// </summary>
        public ParseToOCSF ParseToOCSF
        {
            get { return this._parseToOCSF; }
            set { this._parseToOCSF = value; }
        }

        // Check to see if ParseToOCSF property is set
        internal bool IsSetParseToOCSF()
        {
            return this._parseToOCSF != null;
        }

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
        public ParseVPC ParseVPC
        {
            get { return this._parsevpc; }
            set { this._parsevpc = value; }
        }

        // Check to see if ParseVPC property is set
        internal bool IsSetParseVPC()
        {
            return this._parsevpc != null;
        }

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
        public ParseWAF ParseWAF
        {
            get { return this._parsewaf; }
            set { this._parsewaf = value; }
        }

        // Check to see if ParseWAF property is set
        internal bool IsSetParseWAF()
        {
            return this._parsewaf != null;
        }

        /// <summary>
        /// Gets and sets the property RenameKeys. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-renameKeys">
        /// renameKeys</a> processor in your transformer.
        /// </para>
        /// </summary>
        public RenameKeys RenameKeys
        {
            get { return this._renameKeys; }
            set { this._renameKeys = value; }
        }

        // Check to see if RenameKeys property is set
        internal bool IsSetRenameKeys()
        {
            return this._renameKeys != null;
        }

        /// <summary>
        /// Gets and sets the property SplitString. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-splitString">
        /// splitString</a> processor in your transformer.
        /// </para>
        /// </summary>
        public SplitString SplitString
        {
            get { return this._splitString; }
            set { this._splitString = value; }
        }

        // Check to see if SplitString property is set
        internal bool IsSetSplitString()
        {
            return this._splitString != null;
        }

        /// <summary>
        /// Gets and sets the property SubstituteString. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-substituteString">
        /// substituteString</a> processor in your transformer.
        /// </para>
        /// </summary>
        public SubstituteString SubstituteString
        {
            get { return this._substituteString; }
            set { this._substituteString = value; }
        }

        // Check to see if SubstituteString property is set
        internal bool IsSetSubstituteString()
        {
            return this._substituteString != null;
        }

        /// <summary>
        /// Gets and sets the property TrimString. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-trimString">
        /// trimString</a> processor in your transformer.
        /// </para>
        /// </summary>
        public TrimString TrimString
        {
            get { return this._trimString; }
            set { this._trimString = value; }
        }

        // Check to see if TrimString property is set
        internal bool IsSetTrimString()
        {
            return this._trimString != null;
        }

        /// <summary>
        /// Gets and sets the property TypeConverter. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-typeConverter">
        /// typeConverter</a> processor in your transformer.
        /// </para>
        /// </summary>
        public TypeConverter TypeConverter
        {
            get { return this._typeConverter; }
            set { this._typeConverter = value; }
        }

        // Check to see if TypeConverter property is set
        internal bool IsSetTypeConverter()
        {
            return this._typeConverter != null;
        }

        /// <summary>
        /// Gets and sets the property UpperCaseString. 
        /// <para>
        /// Use this parameter to include the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-upperCaseString">
        /// upperCaseString</a> processor in your transformer.
        /// </para>
        /// </summary>
        public UpperCaseString UpperCaseString
        {
            get { return this._upperCaseString; }
            set { this._upperCaseString = value; }
        }

        // Check to see if UpperCaseString property is set
        internal bool IsSetUpperCaseString()
        {
            return this._upperCaseString != null;
        }

    }
}