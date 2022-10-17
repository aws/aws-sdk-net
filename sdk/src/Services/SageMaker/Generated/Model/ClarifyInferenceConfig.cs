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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The inference configuration parameter for the model container.
    /// </summary>
    public partial class ClarifyInferenceConfig
    {
        private string _contentTemplate;
        private List<string> _featureHeaders = new List<string>();
        private string _featuresAttribute;
        private List<string> _featureTypes = new List<string>();
        private string _labelAttribute;
        private List<string> _labelHeaders = new List<string>();
        private int? _labelIndex;
        private int? _maxPayloadInMB;
        private int? _maxRecordCount;
        private string _probabilityAttribute;
        private int? _probabilityIndex;

        /// <summary>
        /// Gets and sets the property ContentTemplate. 
        /// <para>
        /// A template string used to format a JSON record into an acceptable model container
        /// input. For example, a <code>ContentTemplate</code> string <code>'{"myfeatures":$features}'</code>
        /// will format a list of features <code>[1,2,3]</code> into the record string <code>'{"myfeatures":[1,2,3]}'</code>.
        /// Required only when the model container input is in JSON Lines format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ContentTemplate
        {
            get { return this._contentTemplate; }
            set { this._contentTemplate = value; }
        }

        // Check to see if ContentTemplate property is set
        internal bool IsSetContentTemplate()
        {
            return this._contentTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureHeaders. 
        /// <para>
        /// The names of the features. If provided, these are included in the endpoint response
        /// payload to help readability of the <code>InvokeEndpoint</code> output. See the <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/clarify-online-explainability-invoke-endpoint.html#clarify-online-explainability-response">Response</a>
        /// section under <b>Invoke the endpoint</b> in the Developer Guide for more information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public List<string> FeatureHeaders
        {
            get { return this._featureHeaders; }
            set { this._featureHeaders = value; }
        }

        // Check to see if FeatureHeaders property is set
        internal bool IsSetFeatureHeaders()
        {
            return this._featureHeaders != null && this._featureHeaders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FeaturesAttribute. 
        /// <para>
        /// Provides the JMESPath expression to extract the features from a model container input
        /// in JSON Lines format. For example, if <code>FeaturesAttribute</code> is the JMESPath
        /// expression <code>'myfeatures'</code>, it extracts a list of features <code>[1,2,3]</code>
        /// from request data <code>'{"myfeatures":[1,2,3]}'</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string FeaturesAttribute
        {
            get { return this._featuresAttribute; }
            set { this._featuresAttribute = value; }
        }

        // Check to see if FeaturesAttribute property is set
        internal bool IsSetFeaturesAttribute()
        {
            return this._featuresAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureTypes. 
        /// <para>
        /// A list of data types of the features (optional). Applicable only to NLP explainability.
        /// If provided, <code>FeatureTypes</code> must have at least one <code>'text'</code>
        /// string (for example, <code>['text']</code>). If <code>FeatureTypes</code> is not provided,
        /// the explainer infers the feature types based on the baseline data. The feature types
        /// are included in the endpoint response payload. For additional information see the
        /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/clarify-online-explainability-invoke-endpoint.html#clarify-online-explainability-response">response</a>
        /// section under <b>Invoke the endpoint</b> in the Developer Guide for more information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public List<string> FeatureTypes
        {
            get { return this._featureTypes; }
            set { this._featureTypes = value; }
        }

        // Check to see if FeatureTypes property is set
        internal bool IsSetFeatureTypes()
        {
            return this._featureTypes != null && this._featureTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LabelAttribute. 
        /// <para>
        /// A JMESPath expression used to locate the list of label headers in the model container
        /// output.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example</b>: If the model container output of a batch request is <code>'{"labels":["cat","dog","fish"],"probability":[0.6,0.3,0.1]}'</code>,
        /// then set <code>LabelAttribute</code> to <code>'labels'</code> to extract the list
        /// of label headers <code>["cat","dog","fish"]</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string LabelAttribute
        {
            get { return this._labelAttribute; }
            set { this._labelAttribute = value; }
        }

        // Check to see if LabelAttribute property is set
        internal bool IsSetLabelAttribute()
        {
            return this._labelAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property LabelHeaders. 
        /// <para>
        /// For multiclass classification problems, the label headers are the names of the classes.
        /// Otherwise, the label header is the name of the predicted label. These are used to
        /// help readability for the output of the <code>InvokeEndpoint</code> API. See the <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/clarify-online-explainability-invoke-endpoint.html#clarify-online-explainability-response">response</a>
        /// section under <b>Invoke the endpoint</b> in the Developer Guide for more information.
        /// If there are no label headers in the model container output, provide them manually
        /// using this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=16)]
        public List<string> LabelHeaders
        {
            get { return this._labelHeaders; }
            set { this._labelHeaders = value; }
        }

        // Check to see if LabelHeaders property is set
        internal bool IsSetLabelHeaders()
        {
            return this._labelHeaders != null && this._labelHeaders.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LabelIndex. 
        /// <para>
        /// A zero-based index used to extract a label header or list of label headers from model
        /// container output in CSV format.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example for a multiclass model:</b> If the model container output consists of
        /// label headers followed by probabilities: <code>'"[\'cat\',\'dog\',\'fish\']","[0.1,0.6,0.3]"'</code>,
        /// set <code>LabelIndex</code> to <code>0</code> to select the label headers <code>['cat','dog','fish']</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int LabelIndex
        {
            get { return this._labelIndex.GetValueOrDefault(); }
            set { this._labelIndex = value; }
        }

        // Check to see if LabelIndex property is set
        internal bool IsSetLabelIndex()
        {
            return this._labelIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxPayloadInMB. 
        /// <para>
        /// The maximum payload size (MB) allowed of a request from the explainer to the model
        /// container. Defaults to <code>6</code> MB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public int MaxPayloadInMB
        {
            get { return this._maxPayloadInMB.GetValueOrDefault(); }
            set { this._maxPayloadInMB = value; }
        }

        // Check to see if MaxPayloadInMB property is set
        internal bool IsSetMaxPayloadInMB()
        {
            return this._maxPayloadInMB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRecordCount. 
        /// <para>
        /// The maximum number of records in a request that the model container can process when
        /// querying the model container for the predictions of a <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/clarify-online-explainability-create-endpoint.html#clarify-online-explainability-create-endpoint-synthetic">synthetic
        /// dataset</a>. A record is a unit of input data that inference can be made on, for example,
        /// a single line in CSV data. If <code>MaxRecordCount</code> is <code>1</code>, the model
        /// container expects one record per request. A value of 2 or greater means that the model
        /// expects batch requests, which can reduce overhead and speed up the inferencing process.
        /// If this parameter is not provided, the explainer will tune the record count per request
        /// according to the model container's capacity at runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int MaxRecordCount
        {
            get { return this._maxRecordCount.GetValueOrDefault(); }
            set { this._maxRecordCount = value; }
        }

        // Check to see if MaxRecordCount property is set
        internal bool IsSetMaxRecordCount()
        {
            return this._maxRecordCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProbabilityAttribute. 
        /// <para>
        /// A JMESPath expression used to extract the probability (or score) from the model container
        /// output if the model container is in JSON Lines format.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example</b>: If the model container output of a single request is <code>'{"predicted_label":1,"probability":0.6}'</code>,
        /// then set <code>ProbabilityAttribute</code> to <code>'probability'</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ProbabilityAttribute
        {
            get { return this._probabilityAttribute; }
            set { this._probabilityAttribute = value; }
        }

        // Check to see if ProbabilityAttribute property is set
        internal bool IsSetProbabilityAttribute()
        {
            return this._probabilityAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property ProbabilityIndex. 
        /// <para>
        /// A zero-based index used to extract a probability value (score) or list from model
        /// container output in CSV format. If this value is not provided, the entire model container
        /// output will be treated as a probability value (score) or list.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example for a single class model:</b> If the model container output consists of
        /// a string-formatted prediction label followed by its probability: <code>'1,0.6'</code>,
        /// set <code>ProbabilityIndex</code> to <code>1</code> to select the probability value
        /// <code>0.6</code>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example for a multiclass model:</b> If the model container output consists of
        /// a string-formatted prediction label followed by its probability: <code>'"[\'cat\',\'dog\',\'fish\']","[0.1,0.6,0.3]"'</code>,
        /// set <code>ProbabilityIndex</code> to <code>1</code> to select the probability values
        /// <code>[0.1,0.6,0.3]</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int ProbabilityIndex
        {
            get { return this._probabilityIndex.GetValueOrDefault(); }
            set { this._probabilityIndex = value; }
        }

        // Check to see if ProbabilityIndex property is set
        internal bool IsSetProbabilityIndex()
        {
            return this._probabilityIndex.HasValue; 
        }

    }
}