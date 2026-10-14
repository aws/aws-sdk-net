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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The inference configuration parameter for the model container.
    /// </summary>
    public partial class ClarifyInferenceConfig
    {
        /// <summary>
        /// Gets and sets the property ContentTemplate. 
        /// <para>
        /// A template string used to format a JSON record into an acceptable model container
        /// input. For example, a <c>ContentTemplate</c> string <c>'{"myfeatures":$features}'</c>
        /// will format a list of features <c>[1,2,3]</c> into the record string <c>'{"myfeatures":[1,2,3]}'</c>.
        /// Required only when the model container input is in JSON Lines format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ContentTemplate { get; set; }

        /// <summary>
        /// Checks to see if the ContentTemplate property is set.
        /// </summary>
        internal bool IsSetContentTemplate() => this.ContentTemplate != null;

        /// <summary>
        /// Gets and sets the property FeatureHeaders. 
        /// <para>
        /// The names of the features. If provided, these are included in the endpoint response
        /// payload to help readability of the <c>InvokeEndpoint</c> output. See the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/clarify-online-explainability-invoke-endpoint.html#clarify-online-explainability-response">Response</a>
        /// section under <b>Invoke the endpoint</b> in the Developer Guide for more information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public List<string> FeatureHeaders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FeatureHeaders property is set.
        /// </summary>
        internal bool IsSetFeatureHeaders() => this.FeatureHeaders != null && (this.FeatureHeaders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FeatureTypes. 
        /// <para>
        /// A list of data types of the features (optional). Applicable only to NLP explainability.
        /// If provided, <c>FeatureTypes</c> must have at least one <c>'text'</c> string (for
        /// example, <c>['text']</c>). If <c>FeatureTypes</c> is not provided, the explainer infers
        /// the feature types based on the baseline data. The feature types are included in the
        /// endpoint response payload. For additional information see the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/clarify-online-explainability-invoke-endpoint.html#clarify-online-explainability-response">response</a>
        /// section under <b>Invoke the endpoint</b> in the Developer Guide for more information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public List<string> FeatureTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FeatureTypes property is set.
        /// </summary>
        internal bool IsSetFeatureTypes() => this.FeatureTypes != null && (this.FeatureTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FeaturesAttribute. 
        /// <para>
        /// Provides the JMESPath expression to extract the features from a model container input
        /// in JSON Lines format. For example, if <c>FeaturesAttribute</c> is the JMESPath expression
        /// <c>'myfeatures'</c>, it extracts a list of features <c>[1,2,3]</c> from request data
        /// <c>'{"myfeatures":[1,2,3]}'</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FeaturesAttribute { get; set; }

        /// <summary>
        /// Checks to see if the FeaturesAttribute property is set.
        /// </summary>
        internal bool IsSetFeaturesAttribute() => this.FeaturesAttribute != null;

        /// <summary>
        /// Gets and sets the property LabelAttribute. 
        /// <para>
        /// A JMESPath expression used to locate the list of label headers in the model container
        /// output.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example</b>: If the model container output of a batch request is <c>'{"labels":["cat","dog","fish"],"probability":[0.6,0.3,0.1]}'</c>,
        /// then set <c>LabelAttribute</c> to <c>'labels'</c> to extract the list of label headers
        /// <c>["cat","dog","fish"]</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string LabelAttribute { get; set; }

        /// <summary>
        /// Checks to see if the LabelAttribute property is set.
        /// </summary>
        internal bool IsSetLabelAttribute() => this.LabelAttribute != null;

        /// <summary>
        /// Gets and sets the property LabelHeaders. 
        /// <para>
        /// For multiclass classification problems, the label headers are the names of the classes.
        /// Otherwise, the label header is the name of the predicted label. These are used to
        /// help readability for the output of the <c>InvokeEndpoint</c> API. See the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/clarify-online-explainability-invoke-endpoint.html#clarify-online-explainability-response">response</a>
        /// section under <b>Invoke the endpoint</b> in the Developer Guide for more information.
        /// If there are no label headers in the model container output, provide them manually
        /// using this parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 16)]
        public List<string> LabelHeaders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LabelHeaders property is set.
        /// </summary>
        internal bool IsSetLabelHeaders() => this.LabelHeaders != null && (this.LabelHeaders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LabelIndex. 
        /// <para>
        /// A zero-based index used to extract a label header or list of label headers from model
        /// container output in CSV format.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example for a multiclass model:</b> If the model container output consists of
        /// label headers followed by probabilities: <c>'"[\'cat\',\'dog\',\'fish\']","[0.1,0.6,0.3]"'</c>,
        /// set <c>LabelIndex</c> to <c>0</c> to select the label headers <c>['cat','dog','fish']</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? LabelIndex { get; set; }

        /// <summary>
        /// Checks to see if the LabelIndex property is set.
        /// </summary>
        internal bool IsSetLabelIndex() => this.LabelIndex.HasValue;

        /// <summary>
        /// Gets and sets the property MaxPayloadInMB. 
        /// <para>
        /// The maximum payload size (MB) allowed of a request from the explainer to the model
        /// container. Defaults to <c>6</c> MB.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxPayloadInMB { get; set; }

        /// <summary>
        /// Checks to see if the MaxPayloadInMB property is set.
        /// </summary>
        internal bool IsSetMaxPayloadInMB() => this.MaxPayloadInMB.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRecordCount. 
        /// <para>
        /// The maximum number of records in a request that the model container can process when
        /// querying the model container for the predictions of a <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/clarify-online-explainability-create-endpoint.html#clarify-online-explainability-create-endpoint-synthetic">synthetic
        /// dataset</a>. A record is a unit of input data that inference can be made on, for example,
        /// a single line in CSV data. If <c>MaxRecordCount</c> is <c>1</c>, the model container
        /// expects one record per request. A value of 2 or greater means that the model expects
        /// batch requests, which can reduce overhead and speed up the inferencing process. If
        /// this parameter is not provided, the explainer will tune the record count per request
        /// according to the model container's capacity at runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MaxRecordCount { get; set; }

        /// <summary>
        /// Checks to see if the MaxRecordCount property is set.
        /// </summary>
        internal bool IsSetMaxRecordCount() => this.MaxRecordCount.HasValue;

        /// <summary>
        /// Gets and sets the property ProbabilityAttribute. 
        /// <para>
        /// A JMESPath expression used to extract the probability (or score) from the model container
        /// output if the model container is in JSON Lines format.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example</b>: If the model container output of a single request is <c>'{"predicted_label":1,"probability":0.6}'</c>,
        /// then set <c>ProbabilityAttribute</c> to <c>'probability'</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ProbabilityAttribute { get; set; }

        /// <summary>
        /// Checks to see if the ProbabilityAttribute property is set.
        /// </summary>
        internal bool IsSetProbabilityAttribute() => this.ProbabilityAttribute != null;

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
        /// a string-formatted prediction label followed by its probability: <c>'1,0.6'</c>, set
        /// <c>ProbabilityIndex</c> to <c>1</c> to select the probability value <c>0.6</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Example for a multiclass model:</b> If the model container output consists of
        /// a string-formatted prediction label followed by its probability: <c>'"[\'cat\',\'dog\',\'fish\']","[0.1,0.6,0.3]"'</c>,
        /// set <c>ProbabilityIndex</c> to <c>1</c> to select the probability values <c>[0.1,0.6,0.3]</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ProbabilityIndex { get; set; }

        /// <summary>
        /// Checks to see if the ProbabilityIndex property is set.
        /// </summary>
        internal bool IsSetProbabilityIndex() => this.ProbabilityIndex.HasValue;
    }
}
