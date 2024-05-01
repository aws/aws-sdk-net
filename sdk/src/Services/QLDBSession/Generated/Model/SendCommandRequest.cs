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
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
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
namespace Amazon.QLDBSession.Model
{
    /// <summary>
    /// Container for the parameters to the SendCommand operation.
    /// Sends a command to an Amazon QLDB ledger.
    /// 
    ///  <note> 
    /// <para>
    /// Instead of interacting directly with this API, we recommend using the QLDB driver
    /// or the QLDB shell to execute data transactions on a ledger.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If you are working with an AWS SDK, use the QLDB driver. The driver provides a high-level
    /// abstraction layer above this <i>QLDB Session</i> data plane and manages <c>SendCommand</c>
    /// API calls for you. For information and a list of supported programming languages,
    /// see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/getting-started-driver.html">Getting
    /// started with the driver</a> in the <i>Amazon QLDB Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you are working with the AWS Command Line Interface (AWS CLI), use the QLDB shell.
    /// The shell is a command line interface that uses the QLDB driver to interact with a
    /// ledger. For information, see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/data-shell.html">Accessing
    /// Amazon QLDB using the QLDB shell</a>.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class SendCommandRequest : AmazonQLDBSessionRequest
    {
        private AbortTransactionRequest _abortTransaction;
        private CommitTransactionRequest _commitTransaction;
        private EndSessionRequest _endSession;
        private ExecuteStatementRequest _executeStatement;
        private FetchPageRequest _fetchPage;
        private string _sessionToken;
        private StartSessionRequest _startSession;
        private StartTransactionRequest _startTransaction;

        /// <summary>
        /// Gets and sets the property AbortTransaction. 
        /// <para>
        /// Command to abort the current transaction.
        /// </para>
        /// </summary>
        public AbortTransactionRequest AbortTransaction
        {
            get { return this._abortTransaction; }
            set { this._abortTransaction = value; }
        }

        // Check to see if AbortTransaction property is set
        internal bool IsSetAbortTransaction()
        {
            return this._abortTransaction != null;
        }

        /// <summary>
        /// Gets and sets the property CommitTransaction. 
        /// <para>
        /// Command to commit the specified transaction.
        /// </para>
        /// </summary>
        public CommitTransactionRequest CommitTransaction
        {
            get { return this._commitTransaction; }
            set { this._commitTransaction = value; }
        }

        // Check to see if CommitTransaction property is set
        internal bool IsSetCommitTransaction()
        {
            return this._commitTransaction != null;
        }

        /// <summary>
        /// Gets and sets the property EndSession. 
        /// <para>
        /// Command to end the current session.
        /// </para>
        /// </summary>
        public EndSessionRequest EndSession
        {
            get { return this._endSession; }
            set { this._endSession = value; }
        }

        // Check to see if EndSession property is set
        internal bool IsSetEndSession()
        {
            return this._endSession != null;
        }

        /// <summary>
        /// Gets and sets the property ExecuteStatement. 
        /// <para>
        /// Command to execute a statement in the specified transaction.
        /// </para>
        /// </summary>
        public ExecuteStatementRequest ExecuteStatement
        {
            get { return this._executeStatement; }
            set { this._executeStatement = value; }
        }

        // Check to see if ExecuteStatement property is set
        internal bool IsSetExecuteStatement()
        {
            return this._executeStatement != null;
        }

        /// <summary>
        /// Gets and sets the property FetchPage. 
        /// <para>
        /// Command to fetch a page.
        /// </para>
        /// </summary>
        public FetchPageRequest FetchPage
        {
            get { return this._fetchPage; }
            set { this._fetchPage = value; }
        }

        // Check to see if FetchPage property is set
        internal bool IsSetFetchPage()
        {
            return this._fetchPage != null;
        }

        /// <summary>
        /// Gets and sets the property SessionToken. 
        /// <para>
        /// Specifies the session token for the current command. A session token is constant throughout
        /// the life of the session.
        /// </para>
        ///  
        /// <para>
        /// To obtain a session token, run the <c>StartSession</c> command. This <c>SessionToken</c>
        /// is required for every subsequent command that is issued during the current session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
        public string SessionToken
        {
            get { return this._sessionToken; }
            set { this._sessionToken = value; }
        }

        // Check to see if SessionToken property is set
        internal bool IsSetSessionToken()
        {
            return this._sessionToken != null;
        }

        /// <summary>
        /// Gets and sets the property StartSession. 
        /// <para>
        /// Command to start a new session. A session token is obtained as part of the response.
        /// </para>
        /// </summary>
        public StartSessionRequest StartSession
        {
            get { return this._startSession; }
            set { this._startSession = value; }
        }

        // Check to see if StartSession property is set
        internal bool IsSetStartSession()
        {
            return this._startSession != null;
        }

        /// <summary>
        /// Gets and sets the property StartTransaction. 
        /// <para>
        /// Command to start a new transaction.
        /// </para>
        /// </summary>
        public StartTransactionRequest StartTransaction
        {
            get { return this._startTransaction; }
            set { this._startTransaction = value; }
        }

        // Check to see if StartTransaction property is set
        internal bool IsSetStartTransaction()
        {
            return this._startTransaction != null;
        }

    }
}