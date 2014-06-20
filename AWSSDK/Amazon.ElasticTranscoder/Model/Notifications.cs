/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The Amazon Simple Notification Service (Amazon SNS) topic or topics to notify in order
    /// to report job status.
    /// 
    ///         <important>To receive notifications, you must also subscribe to the new topic
    /// in the Amazon SNS            console.</important>
    /// </summary>
    public partial class Notifications
    {
        private string _completed;
        private string _error;
        private string _progressing;
        private string _warning;


        /// <summary>
        /// Gets and sets the property Completed. 
        /// <para>
        /// The Amazon SNS topic that you want to notify when Elastic Transcoder has finished
        /// processing the job.
        /// </para>
        /// </summary>
        public string Completed
        {
            get { return this._completed; }
            set { this._completed = value; }
        }


        /// <summary>
        /// Sets the Completed property
        /// </summary>
        /// <param name="completed">The value to set for the Completed property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Notifications WithCompleted(string completed)
        {
            this._completed = completed;
            return this;
        }

        // Check to see if Completed property is set
        internal bool IsSetCompleted()
        {
            return this._completed != null;
        }


        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The Amazon SNS topic that you want to notify when Elastic Transcoder encounters an
        /// error condition.
        /// </para>
        /// </summary>
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }


        /// <summary>
        /// Sets the Error property
        /// </summary>
        /// <param name="error">The value to set for the Error property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Notifications WithError(string error)
        {
            this._error = error;
            return this;
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }


        /// <summary>
        /// Gets and sets the property Progressing. 
        /// <para>
        /// The Amazon Simple Notification Service (Amazon SNS) topic that you want to notify
        /// when Elastic Transcoder has started to process the            job.
        /// </para>
        /// </summary>
        public string Progressing
        {
            get { return this._progressing; }
            set { this._progressing = value; }
        }


        /// <summary>
        /// Sets the Progressing property
        /// </summary>
        /// <param name="progressing">The value to set for the Progressing property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Notifications WithProgressing(string progressing)
        {
            this._progressing = progressing;
            return this;
        }

        // Check to see if Progressing property is set
        internal bool IsSetProgressing()
        {
            return this._progressing != null;
        }


        /// <summary>
        /// Gets and sets the property Warning. 
        /// <para>
        /// The Amazon SNS topic that you want to notify when Elastic Transcoder encounters a
        /// warning condition.
        /// </para>
        /// </summary>
        public string Warning
        {
            get { return this._warning; }
            set { this._warning = value; }
        }


        /// <summary>
        /// Sets the Warning property
        /// </summary>
        /// <param name="warning">The value to set for the Warning property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Notifications WithWarning(string warning)
        {
            this._warning = warning;
            return this;
        }

        // Check to see if Warning property is set
        internal bool IsSetWarning()
        {
            return this._warning != null;
        }

    }
}