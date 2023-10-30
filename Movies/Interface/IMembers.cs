﻿using System.Collections.Generic;

namespace Movies
{
    internal interface IMembers
    {
        void Print();
        bool Login(string logName,string password);
        void RemoveMember(int memberId);
        void RecoveryInformation(string name, MembersSystem upDateMember);
        void Registration(MembersSystem member);
        List<MembersSystem> Search(string memberName);
    }
}
