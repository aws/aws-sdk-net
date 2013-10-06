/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para>The Amazon Simple Notification Service (Amazon SNS) topic or topics to notify in order to report job status.</para>
    /// <para><b>IMPORTANT:</b>To receive notifications, you must also subscribe to the new topic in the Amazon SNS console.</para>
    /// </summary>
    public class Notifications
    {
        
        private string progressing;
        private string completed;
        private string warning;
        private string error;

        /// <summary>
        /// The Amazon Simple Notification Service (Amazon SNS) topic that you want to notify when Elastic Transcoder has started to process the job.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^$)|(^arn:aws:sns:.*:\w{12}:.+$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Progressing
        {
            get { return this.progressing; }
            set { this.progressing = value; }
        }

        /// <summary>
        /// Sets the Progressing property
        /// </summary>
        /// <param name="progressing">The value to set for the Progressing property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Notifications WithProgressing(string progressing)
        {
            this.progressing = progressing;
            return this;
        }
            

        // Check to see if Progressing property is set
        internal bool IsSetProgressing()
        {
            return this.progressing != null;
        }

        /// <summary>
        /// The Amazon SNS topic that you want to notify when Elastic Transcoder has finished processing the job.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^$)|(^arn:aws:sns:.*:\w{12}:.+$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Completed
        {
            get { return this.completed; }
            set { this.completed = value; }
        }

        /// <summary>
        /// Sets the Completed property
        /// </summary>
        /// <param name="completed">The value to set for the Completed property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Notifications WithCompleted(string completed)
        {
            this.completed = completed;
            return this;
        }
            

        // Check to see if Completed property is set
        internal bool IsSetCompleted()
        {
            return this.completed != null;
        }

        /// <summary>
        /// The Amazon SNS topic that you want to notify when Elastic Transcoder encounters a warning condition.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^$)|(^arn:aws:sns:.*:\w{12}:.+$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Warning
        {
            get { return this.warning; }
            set { this.warning = value; }
        }

        /// <summary>
        /// Sets the Warning property
        /// </summary>
        /// <param name="warning">The value to set for the Warning property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Notifications WithWarning(string warning)
        {
            this.warning = warning;
            return this;
        }
            

        // Check to see if Warning property is set
        internal bool IsSetWarning()
        {
            return this.warning != null;
        }

        /// <summary>
        /// The Amazon SNS topic that you want to notify when Elastic Transcoder encounters an error condition.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^$)|(^arn:aws:sns:.*:\w{12}:.+$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Error
        {
            get { return this.error; }
            set { this.error = value; }
        }

        /// <summary>
        /// Sets the Error property
        /// </summary>
        /// <param name="error">The value to set for the Error property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Notifications WithError(string error)
        {
            this.error = error;
            return this;
        }
            

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this.error != null;
        }
    }
}
