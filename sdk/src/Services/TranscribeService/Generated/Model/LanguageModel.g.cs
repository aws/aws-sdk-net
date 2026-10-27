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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Provides information about a custom language model, including:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The base model name
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the model was created
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The location of the files used to train the model
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the model was last modified
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The name you chose for the model
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The model's language
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The model's processing state
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Any available upgrades for the base model
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class LanguageModel
    {
        /// <summary>
        /// Gets and sets the property BaseModelName. 
        /// <para>
        /// The Amazon Transcribe standard language model, or base model, used to create your
        /// custom language model.
        /// </para>
        /// </summary>
        public BaseModelName BaseModelName { get; set; }

        /// <summary>
        /// Checks to see if the BaseModelName property is set.
        /// </summary>
        internal bool IsSetBaseModelName() => this.BaseModelName != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time the specified custom language model was created.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:32:58.761000-07:00</c> represents 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration used for your custom language model.
        /// </para>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If <c>ModelStatus</c> is <c>FAILED</c>, <c>FailureReason</c> contains information
        /// about why the custom language model request failed. See also: <a href="https://docs.aws.amazon.com/transcribe/latest/APIReference/CommonErrors.html">Common
        /// Errors</a>.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// The Amazon S3 location of the input files used to train and tune your custom language
        /// model, in addition to the data access role ARN (Amazon Resource Name) that has permissions
        /// to access these data.
        /// </para>
        /// </summary>
        public InputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language code used to create your custom language model. Each custom language
        /// model must contain terms in only one language, and the language you select for your
        /// custom language model must match the language of your training and tuning data.
        /// </para>
        ///  
        /// <para>
        /// For a list of supported languages and their associated language codes, refer to the
        /// <a href="https://docs.aws.amazon.com/transcribe/latest/dg/supported-languages.html">Supported
        /// languages</a> table. Note that US English (<c>en-US</c>) is the only language supported
        /// with Amazon Transcribe Medical.
        /// </para>
        /// </summary>
        public CLMLanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time the specified custom language model was last modified.
        /// </para>
        ///  
        /// <para>
        /// Timestamps are in the format <c>YYYY-MM-DD'T'HH:MM:SS.SSSSSS-UTC</c>. For example,
        /// <c>2022-05-04T12:32:58.761000-07:00</c> represents 12:32 PM UTC-7 on May 4, 2022.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// A unique name, chosen by you, for your custom language model.
        /// </para>
        ///  
        /// <para>
        /// This name is case sensitive, cannot contain spaces, and must be unique within an Amazon
        /// Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property ModelStatus. 
        /// <para>
        /// The status of the specified custom language model. When the status displays as <c>COMPLETED</c>
        /// the model is ready for use.
        /// </para>
        /// </summary>
        public ModelStatus ModelStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelStatus property is set.
        /// </summary>
        internal bool IsSetModelStatus() => this.ModelStatus != null;

        /// <summary>
        /// Gets and sets the property UpgradeAvailability. 
        /// <para>
        /// Shows if a more current base model is available for use with the specified custom
        /// language model.
        /// </para>
        ///  
        /// <para>
        /// If <c>false</c>, your custom language model is using the most up-to-date base model.
        /// </para>
        ///  
        /// <para>
        /// If <c>true</c>, there is a newer base model available than the one your language model
        /// is using.
        /// </para>
        ///  
        /// <para>
        /// Note that to update a base model, you must recreate the custom language model using
        /// the new base model. Base model upgrades for existing custom language models are not
        /// supported.
        /// </para>
        /// </summary>
        public bool? UpgradeAvailability { get; set; }

        /// <summary>
        /// Checks to see if the UpgradeAvailability property is set.
        /// </summary>
        internal bool IsSetUpgradeAvailability() => this.UpgradeAvailability.HasValue;
    }
}
