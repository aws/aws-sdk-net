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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies a transform that identifies, removes or masks PII data.
    /// </summary>
    public partial class PIIDetection
    {
        private List<string> _entityTypesToDetect = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _inputs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _maskValue;
        private string _name;
        private string _outputColumnName;
        private PiiType _piiType;
        private double? _sampleFraction;
        private double? _thresholdFraction;

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
        /// Gets and sets the property SampleFraction. 
        /// <para>
        /// Indicates the fraction of the data to sample when scanning for PII entities. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public double SampleFraction
        {
            get { return this._sampleFraction.GetValueOrDefault(); }
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
        public double ThresholdFraction
        {
            get { return this._thresholdFraction.GetValueOrDefault(); }
            set { this._thresholdFraction = value; }
        }

        // Check to see if ThresholdFraction property is set
        internal bool IsSetThresholdFraction()
        {
            return this._thresholdFraction.HasValue; 
        }

    }
}