﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest578
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest578Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("a60bd84b-ccca-4c99-a2e1-1c0af7a6aaa0")]
    public partial class MyTest578Repository : RepoGenBaseFolder
    {
        static MyTest578Repository instance = new MyTest578Repository();
        MyTest578RepositoryFolders.RxMainFrameAppFolder _rxmainframe;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest578Repository element repository.
        /// </summary>
        [RepositoryFolder("a60bd84b-ccca-4c99-a2e1-1c0af7a6aaa0")]
        public static MyTest578Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest578Repository() 
            : base("MyTest578Repository", "/", null, 0, false, "a60bd84b-ccca-4c99-a2e1-1c0af7a6aaa0", ".\\RepositoryImages\\MyTest578Repositorya60bd84b.rximgres")
        {
            _rxmainframe = new MyTest578RepositoryFolders.RxMainFrameAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("a60bd84b-ccca-4c99-a2e1-1c0af7a6aaa0")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("35c24e2a-ca49-4f4d-93e9-a9aa957aacdf")]
        public virtual MyTest578RepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest578RepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("35c24e2a-ca49-4f4d-93e9-a9aa957aacdf")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _btnsubmitusernameInfo;
            RepoItemInfo _enteryournameInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@controlname='RxMainFrame']", parentFolder, 30000, null, true, "35c24e2a-ca49-4f4d-93e9-a9aa957aacdf", "")
            {
                _btnsubmitusernameInfo = new RepoItemInfo(this, "BtnSubmitUserName", "?/?/tabpage[@controlname='RxTabIntroduction']/button[@controlname='btnSubmitUserName']", ".//button[@controlname='btnSubmitUserName']", 30000, null, "f67f8a2b-a2c8-4623-8348-aff4c9b8b8dc");
                _enteryournameInfo = new RepoItemInfo(this, "EnterYourName", "?/?/tabpage[@controlname='RxTabIntroduction']/?/?/text[@accessiblename='Enter your name']", ".//text[@accessiblename='Enter your name' and @accessiblerole='Text']", 30000, null, "0b8a124f-3a2c-491e-9159-708d7cf4c83d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("35c24e2a-ca49-4f4d-93e9-a9aa957aacdf")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("35c24e2a-ca49-4f4d-93e9-a9aa957aacdf")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item.
            /// </summary>
            [RepositoryItem("f67f8a2b-a2c8-4623-8348-aff4c9b8b8dc")]
            public virtual Ranorex.Button BtnSubmitUserName
            {
                get
                {
                    return _btnsubmitusernameInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item info.
            /// </summary>
            [RepositoryItemInfo("f67f8a2b-a2c8-4623-8348-aff4c9b8b8dc")]
            public virtual RepoItemInfo BtnSubmitUserNameInfo
            {
                get
                {
                    return _btnsubmitusernameInfo;
                }
            }

            /// <summary>
            /// The EnterYourName item.
            /// </summary>
            [RepositoryItem("0b8a124f-3a2c-491e-9159-708d7cf4c83d")]
            public virtual Ranorex.Text EnterYourName
            {
                get
                {
                    return _enteryournameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EnterYourName item info.
            /// </summary>
            [RepositoryItemInfo("0b8a124f-3a2c-491e-9159-708d7cf4c83d")]
            public virtual RepoItemInfo EnterYourNameInfo
            {
                get
                {
                    return _enteryournameInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}