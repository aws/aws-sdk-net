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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// An action that Amazon SES can take when it receives an email on behalf of one or more
    /// email addresses or domains that you own. An instance of this data type can represent
    /// only one action.
    /// 
    ///  
    /// <para>
    /// For information about setting up receipt rules, see the <a href="https://docs.aws.amazon.com/ses/latest/dg/receiving-email-receipt-rules-console-walkthrough.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class ReceiptAction
    {
        /// <summary>
        /// Gets and sets the property AddHeaderAction. 
        /// <para>
        /// Adds a header to the received email.
        /// </para>
        /// </summary>
        public AddHeaderAction AddHeaderAction { get; set; }

        /// <summary>
        /// Checks to see if the AddHeaderAction property is set.
        /// </summary>
        internal bool IsSetAddHeaderAction() => this.AddHeaderAction != null;

        /// <summary>
        /// Gets and sets the property BounceAction. 
        /// <para>
        /// Rejects the received email by returning a bounce response to the sender and, optionally,
        /// publishes a notification to Amazon Simple Notification Service (Amazon SNS).
        /// </para>
        /// </summary>
        public BounceAction BounceAction { get; set; }

        /// <summary>
        /// Checks to see if the BounceAction property is set.
        /// </summary>
        internal bool IsSetBounceAction() => this.BounceAction != null;

        /// <summary>
        /// Gets and sets the property ConnectAction. 
        /// <para>
        /// Parses the received message and starts an email contact in Amazon Connect on your
        /// behalf.
        /// </para>
        /// </summary>
        public ConnectAction ConnectAction { get; set; }

        /// <summary>
        /// Checks to see if the ConnectAction property is set.
        /// </summary>
        internal bool IsSetConnectAction() => this.ConnectAction != null;

        /// <summary>
        /// Gets and sets the property LambdaAction. 
        /// <para>
        /// Calls an Amazon Web Services Lambda function, and optionally, publishes a notification
        /// to Amazon SNS.
        /// </para>
        /// </summary>
        public LambdaAction LambdaAction { get; set; }

        /// <summary>
        /// Checks to see if the LambdaAction property is set.
        /// </summary>
        internal bool IsSetLambdaAction() => this.LambdaAction != null;

        /// <summary>
        /// Gets and sets the property S3Action. 
        /// <para>
        /// Saves the received message to an Amazon Simple Storage Service (Amazon S3) bucket
        /// and, optionally, publishes a notification to Amazon SNS.
        /// </para>
        /// </summary>
        public S3Action S3Action { get; set; }

        /// <summary>
        /// Checks to see if the S3Action property is set.
        /// </summary>
        internal bool IsSetS3Action() => this.S3Action != null;

        /// <summary>
        /// Gets and sets the property SNSAction. 
        /// <para>
        /// Publishes the email content within a notification to Amazon SNS.
        /// </para>
        /// </summary>
        public SNSAction SNSAction { get; set; }

        /// <summary>
        /// Checks to see if the SNSAction property is set.
        /// </summary>
        internal bool IsSetSNSAction() => this.SNSAction != null;

        /// <summary>
        /// Gets and sets the property StopAction. 
        /// <para>
        /// Terminates the evaluation of the receipt rule set and optionally publishes a notification
        /// to Amazon SNS.
        /// </para>
        /// </summary>
        public StopAction StopAction { get; set; }

        /// <summary>
        /// Checks to see if the StopAction property is set.
        /// </summary>
        internal bool IsSetStopAction() => this.StopAction != null;

        /// <summary>
        /// Gets and sets the property WorkmailAction. 
        /// <para>
        /// Calls Amazon WorkMail and, optionally, publishes a notification to Amazon Amazon SNS.
        /// </para>
        /// </summary>
        public WorkmailAction WorkmailAction { get; set; }

        /// <summary>
        /// Checks to see if the WorkmailAction property is set.
        /// </summary>
        internal bool IsSetWorkmailAction() => this.WorkmailAction != null;
    }
}
