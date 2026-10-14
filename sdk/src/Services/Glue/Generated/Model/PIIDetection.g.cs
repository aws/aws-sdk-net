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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a transform that identifies, removes or masks PII data.
    /// </summary>
    public partial class PIIDetection
    {
        /// <summary>
        /// Gets and sets the property DetectionParameters. 
        /// <para>
        /// Additional parameters for configuring PII detection behavior and sensitivity settings.
        /// </para>
        /// </summary>
        public string DetectionParameters { get; set; }

        /// <summary>
        /// Checks to see if the DetectionParameters property is set.
        /// </summary>
        internal bool IsSetDetectionParameters() => this.DetectionParameters != null;

        /// <summary>
        /// Gets and sets the property DetectionSensitivity. 
        /// <para>
        /// The sensitivity level for PII detection. Higher sensitivity levels detect more potential
        /// PII but may result in more false positives.
        /// </para>
        /// </summary>
        public string DetectionSensitivity { get; set; }

        /// <summary>
        /// Checks to see if the DetectionSensitivity property is set.
        /// </summary>
        internal bool IsSetDetectionSensitivity() => this.DetectionSensitivity != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> EntityTypesToDetect { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EntityTypesToDetect property is set.
        /// </summary>
        internal bool IsSetEntityTypesToDetect() => this.EntityTypesToDetect != null && (this.EntityTypesToDetect.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Inputs. 
        /// <para>
        /// The node ID inputs to the transform.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<string> Inputs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Inputs property is set.
        /// </summary>
        internal bool IsSetInputs() => this.Inputs != null && (this.Inputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaskValue. 
        /// <para>
        /// Indicates the value that will replace the detected entity. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string MaskValue { get; set; }

        /// <summary>
        /// Checks to see if the MaskValue property is set.
        /// </summary>
        internal bool IsSetMaskValue() => this.MaskValue != null;

        /// <summary>
        /// Gets and sets the property MatchPattern. 
        /// <para>
        /// A regular expression pattern used to identify additional PII content beyond the standard
        /// detection algorithms.
        /// </para>
        /// </summary>
        public string MatchPattern { get; set; }

        /// <summary>
        /// Checks to see if the MatchPattern property is set.
        /// </summary>
        internal bool IsSetMatchPattern() => this.MatchPattern != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the transform node.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NumLeftCharsToExclude. 
        /// <para>
        /// The number of characters to exclude from redaction on the left side of detected PII
        /// content. This allows preserving context around the sensitive data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? NumLeftCharsToExclude { get; set; }

        /// <summary>
        /// Checks to see if the NumLeftCharsToExclude property is set.
        /// </summary>
        internal bool IsSetNumLeftCharsToExclude() => this.NumLeftCharsToExclude.HasValue;

        /// <summary>
        /// Gets and sets the property NumRightCharsToExclude. 
        /// <para>
        /// The number of characters to exclude from redaction on the right side of detected PII
        /// content. This allows preserving context around the sensitive data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? NumRightCharsToExclude { get; set; }

        /// <summary>
        /// Checks to see if the NumRightCharsToExclude property is set.
        /// </summary>
        internal bool IsSetNumRightCharsToExclude() => this.NumRightCharsToExclude.HasValue;

        /// <summary>
        /// Gets and sets the property OutputColumnName. 
        /// <para>
        /// Indicates the output column name that will contain any entity type detected in that
        /// row. 
        /// </para>
        /// </summary>
        public string OutputColumnName { get; set; }

        /// <summary>
        /// Checks to see if the OutputColumnName property is set.
        /// </summary>
        internal bool IsSetOutputColumnName() => this.OutputColumnName != null;

        /// <summary>
        /// Gets and sets the property PiiType. 
        /// <para>
        /// Indicates the type of PIIDetection transform. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PiiType PiiType { get; set; }

        /// <summary>
        /// Checks to see if the PiiType property is set.
        /// </summary>
        internal bool IsSetPiiType() => this.PiiType != null;

        /// <summary>
        /// Gets and sets the property RedactChar. 
        /// <para>
        /// The character used to replace detected PII content when redaction is enabled. The
        /// default redaction character is <c>*</c>.
        /// </para>
        /// </summary>
        public string RedactChar { get; set; }

        /// <summary>
        /// Checks to see if the RedactChar property is set.
        /// </summary>
        internal bool IsSetRedactChar() => this.RedactChar != null;

        /// <summary>
        /// Gets and sets the property RedactText. 
        /// <para>
        /// Specifies whether to redact the detected PII text. When set to <c>true</c>, PII content
        /// is replaced with redaction characters.
        /// </para>
        /// </summary>
        public string RedactText { get; set; }

        /// <summary>
        /// Checks to see if the RedactText property is set.
        /// </summary>
        internal bool IsSetRedactText() => this.RedactText != null;

        /// <summary>
        /// Gets and sets the property SampleFraction. 
        /// <para>
        /// Indicates the fraction of the data to sample when scanning for PII entities. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? SampleFraction { get; set; }

        /// <summary>
        /// Checks to see if the SampleFraction property is set.
        /// </summary>
        internal bool IsSetSampleFraction() => this.SampleFraction.HasValue;

        /// <summary>
        /// Gets and sets the property ThresholdFraction. 
        /// <para>
        /// Indicates the fraction of the data that must be met in order for a column to be identified
        /// as PII data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public double? ThresholdFraction { get; set; }

        /// <summary>
        /// Checks to see if the ThresholdFraction property is set.
        /// </summary>
        internal bool IsSetThresholdFraction() => this.ThresholdFraction.HasValue;
    }
}
