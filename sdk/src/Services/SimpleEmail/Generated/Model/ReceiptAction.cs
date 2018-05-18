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

/*
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// An action that Amazon SES can take when it receives an email on behalf of one or more
    /// email addresses or domains that you own. An instance of this data type can represent
    /// only one action.
    /// 
    ///  
    /// <para>
    /// For information about setting up receipt rules, see the <a href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/receiving-email-receipt-rules.html">Amazon
    /// SES Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class ReceiptAction
    {
        private AddHeaderAction _addHeaderAction;
        private BounceAction _bounceAction;
        private LambdaAction _lambdaAction;
        private S3Action _s3Action;
        private SNSAction _snsAction;
        private StopAction _stopAction;
        private WorkmailAction _workmailAction;

        /// <summary>
        /// Gets and sets the property AddHeaderAction. 
        /// <para>
        /// Adds a header to the received email.
        /// </para>
        /// </summary>
        public AddHeaderAction AddHeaderAction
        {
            get { return this._addHeaderAction; }
            set { this._addHeaderAction = value; }
        }

        // Check to see if AddHeaderAction property is set
        internal bool IsSetAddHeaderAction()
        {
            return this._addHeaderAction != null;
        }

        /// <summary>
        /// Gets and sets the property BounceAction. 
        /// <para>
        /// Rejects the received email by returning a bounce response to the sender and, optionally,
        /// publishes a notification to Amazon Simple Notification Service (Amazon SNS).
        /// </para>
        /// </summary>
        public BounceAction BounceAction
        {
            get { return this._bounceAction; }
            set { this._bounceAction = value; }
        }

        // Check to see if BounceAction property is set
        internal bool IsSetBounceAction()
        {
            return this._bounceAction != null;
        }

        /// <summary>
        /// Gets and sets the property LambdaAction. 
        /// <para>
        /// Calls an AWS Lambda function, and optionally, publishes a notification to Amazon SNS.
        /// </para>
        /// </summary>
        public LambdaAction LambdaAction
        {
            get { return this._lambdaAction; }
            set { this._lambdaAction = value; }
        }

        // Check to see if LambdaAction property is set
        internal bool IsSetLambdaAction()
        {
            return this._lambdaAction != null;
        }

        /// <summary>
        /// Gets and sets the property S3Action. 
        /// <para>
        /// Saves the received message to an Amazon Simple Storage Service (Amazon S3) bucket
        /// and, optionally, publishes a notification to Amazon SNS.
        /// </para>
        /// </summary>
        public S3Action S3Action
        {
            get { return this._s3Action; }
            set { this._s3Action = value; }
        }

        // Check to see if S3Action property is set
        internal bool IsSetS3Action()
        {
            return this._s3Action != null;
        }

        /// <summary>
        /// Gets and sets the property SNSAction. 
        /// <para>
        /// Publishes the email content within a notification to Amazon SNS.
        /// </para>
        /// </summary>
        public SNSAction SNSAction
        {
            get { return this._snsAction; }
            set { this._snsAction = value; }
        }

        // Check to see if SNSAction property is set
        internal bool IsSetSNSAction()
        {
            return this._snsAction != null;
        }

        /// <summary>
        /// Gets and sets the property StopAction. 
        /// <para>
        /// Terminates the evaluation of the receipt rule set and optionally publishes a notification
        /// to Amazon SNS.
        /// </para>
        /// </summary>
        public StopAction StopAction
        {
            get { return this._stopAction; }
            set { this._stopAction = value; }
        }

        // Check to see if StopAction property is set
        internal bool IsSetStopAction()
        {
            return this._stopAction != null;
        }

        /// <summary>
        /// Gets and sets the property WorkmailAction. 
        /// <para>
        /// Calls Amazon WorkMail and, optionally, publishes a notification to Amazon Amazon SNS.
        /// </para>
        /// </summary>
        public WorkmailAction WorkmailAction
        {
            get { return this._workmailAction; }
            set { this._workmailAction = value; }
        }

        // Check to see if WorkmailAction property is set
        internal bool IsSetWorkmailAction()
        {
            return this._workmailAction != null;
        }

    }
}