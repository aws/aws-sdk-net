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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a transform that identifies, removes or masks PII data.
    /// </summary>
    public partial class PIIDetection
    {
        private string _detectionParameters;
        private string _detectionSensitivity;
        private List<string> _entityTypesToDetect = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _inputs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _maskValue;
        private string _matchPattern;
        private string _name;
        private int? _numLeftCharsToExclude;
        private int? _numRightCharsToExclude;
        private string _outputColumnName;
        private PiiType _piiType;
        private string _redactChar;
        private string _redactText;
        private double? _sampleFraction;
        private double? _thresholdFraction;

        /// <summary>
        /// Gets and sets the property DetectionParameters. 
        /// <para>
        /// Additional parameters for configuring PII detection behavior and sensitivity settings.
        /// </para>
        /// </summary>
        public string DetectionParameters
        {
            get { return this._detectionParameters; }
            set { this._detectionParameters = value; }
        }

        // Check to see if DetectionParameters property is set
        internal bool IsSetDetectionParameters()
        {
            return this._detectionParameters != null;
        }

        /// <summary>
        /// Gets and sets the property DetectionSensitivity. 
        /// <para>
        /// The sensitivity level for PII detection. Higher sensitivity levels detect more potential
        /// PII but may result in more false positives.
        /// </para>
        /// </summary>
        public string DetectionSensitivity
        {
            get { return this._detectionSensitivity; }
            set { this._detectionSensitivity = value; }
        }

        // Check to see if DetectionSensitivity property is set
        internal bool IsSetDetectionSensitivity()
        {
            return this._detectionSensitivity != null;
        }

        /// <summary>
        /// Gets and sets the property EntityTypesToDetect. 
        /// <para>
        /// Indicates the types of entities the PIIDetection transform will identify as PII data.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  PII type entities include: PERSON_NAME, DATE, USA_SNN, EMAIL, USA_ITIN, USA_PASSPORT_NUMBER,
        /// PHONE_NUMBER, BANK_ACCOUNT, IP_ADDRESS, MAC_ADDRESS, USA_CPT_CODE, USA_HCPCS_CODE,
        /// USA_NATIONAL_DRUG_CODE, USA_MEDICARE_BENEFICIARY_IDENTIFIER, USA_HEALTH_INSURANCE_CLAIM_NUMBER,CREDIT_CARD,USA_NATIONAL_PROVIDER_IDENTIFIER,USA_DEA_NUMBER,USA_DRIVING_LICENSE
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> EntityTypesToDetect
        {
            get { return this._entityTypesToDetect; }
            set { this._entityTypesToDetect = value; }
        }

        // Check to see if EntityTypesToDetect property is set
        internal bool IsSetEntityTypesToDetect()
        {
            return this._entityTypesToDetect != null && (this._entityTypesToDetect.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// The node ID inputs to the transform.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> Inputs
        {
            get { return this._inputs; }
            set { this._inputs = value; }
        }

        // Check to see if Inputs property is set
        internal bool IsSetInputs()
        {
            return this._inputs != null && (this._inputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaskValue. 
        /// <para>
        /// Indicates the value that will replace the detected entity. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string MaskValue
        {
            get { return this._maskValue; }
            set { this._maskValue = value; }
        }

        // Check to see if MaskValue property is set
        internal bool IsSetMaskValue()
        {
            return this._maskValue != null;
        }

        /// <summary>
        /// Gets and sets the property MatchPattern. 
        /// <para>
        /// A regular expression pattern used to identify additional PII content beyond the standard
        /// detection algorithms.
        /// </para>
        /// </summary>
        public string MatchPattern
        {
            get { return this._matchPattern; }
            set { this._matchPattern = value; }
        }

        // Check to see if MatchPattern property is set
        internal bool IsSetMatchPattern()
        {
            return this._matchPattern != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the transform node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property NumLeftCharsToExclude. 
        /// <para>
        /// The number of characters to exclude from redaction on the left side of detected PII
        /// content. This allows preserving context around the sensitive data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? NumLeftCharsToExclude
        {
            get { return this._numLeftCharsToExclude; }
            set { this._numLeftCharsToExclude = value; }
        }

        // Check to see if NumLeftCharsToExclude property is set
        internal bool IsSetNumLeftCharsToExclude()
        {
            return this._numLeftCharsToExclude.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumRightCharsToExclude. 
        /// <para>
        /// The number of characters to exclude from redaction on the right side of detected PII
        /// content. This allows preserving context around the sensitive data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? NumRightCharsToExclude
        {
            get { return this._numRightCharsToExclude; }
            set { this._numRightCharsToExclude = value; }
        }

        // Check to see if NumRightCharsToExclude property is set
        internal bool IsSetNumRightCharsToExclude()
        {
            return this._numRightCharsToExclude.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputColumnName. 
        /// <para>
        /// Indicates the output column name that will contain any entity type detected in that
        /// row. 
        /// </para>
        /// </summary>
        public string OutputColumnName
        {
            get { return this._outputColumnName; }
            set { this._outputColumnName = value; }
        }

        // Check to see if OutputColumnName property is set
        internal bool IsSetOutputColumnName()
        {
            return this._outputColumnName != null;
        }

        /// <summary>
        /// Gets and sets the property PiiType. 
        /// <para>
        /// Indicates the type of PIIDetection transform. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PiiType PiiType
        {
            get { return this._piiType; }
            set { this._piiType = value; }
        }

        // Check to see if PiiType property is set
        internal bool IsSetPiiType()
        {
            return this._piiType != null;
        }

        /// <summary>
        /// Gets and sets the property RedactChar. 
        /// <para>
        /// The character used to replace detected PII content when redaction is enabled. The
        /// default redaction character is <c>*</c>.
        /// </para>
        /// </summary>
        public string RedactChar
        {
            get { return this._redactChar; }
            set { this._redactChar = value; }
        }

        // Check to see if RedactChar property is set
        internal bool IsSetRedactChar()
        {
            return this._redactChar != null;
        }

        /// <summary>
        /// Gets and sets the property RedactText. 
        /// <para>
        /// Specifies whether to redact the detected PII text. When set to <c>true</c>, PII content
        /// is replaced with redaction characters.
        /// </para>
        /// </summary>
        public string RedactText
        {
            get { return this._redactText; }
            set { this._redactText = value; }
        }

        // Check to see if RedactText property is set
        internal bool IsSetRedactText()
        {
            return this._redactText != null;
        }

        /// <summary>
        /// Gets and sets the property SampleFraction. 
        /// <para>
        /// Indicates the fraction of the data to sample when scanning for PII entities. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? SampleFraction
        {
            get { return this._sampleFraction; }
            set { this._sampleFraction = value; }
        }

        // Check to see if SampleFraction property is set
        internal bool IsSetSampleFraction()
        {
            return this._sampleFraction.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThresholdFraction. 
        /// <para>
        /// Indicates the fraction of the data that must be met in order for a column to be identified
        /// as PII data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double? ThresholdFraction
        {
            get { return this._thresholdFraction; }
            set { this._thresholdFraction = value; }
        }

        // Check to see if ThresholdFraction property is set
        internal bool IsSetThresholdFraction()
        {
            return this._thresholdFraction.HasValue; 
        }

    }
}